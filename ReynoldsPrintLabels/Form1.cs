using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using ReynoldsPrintLabels.Properties;
using System.IO;
using System.Security.Cryptography;
using Microsoft.VisualBasic.FileIO;


namespace ReynoldsPrintLabels
{
    public partial class Form1 : Form
    {
        private void logger(string msg)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "log.txt", true))
            {
                file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss") +" :: "+ msg);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private List<List<string>> labels = new List<List<string>>();
        private FileSystemWatcher watcher = new FileSystemWatcher();
        private int label_count = 1;
        private string textToPrint = "";
        private bool more_pages = false;
        private bool has_indexing = false;

        private int customer_index, home_index, business_index, quantity_index, part_index, desc_index, group_index, date_index, po_number_index, category_index;

        private void watch()
        {
            try
            {
                watcher.Path = Properties.Settings.Default.path;
                watcher.NotifyFilter = NotifyFilters.LastWrite;
                watcher.Filter = "*.csv";
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                watcher.EnableRaisingEvents = true;
            }
            catch (Exception er) {
                logger(er.ToString());
            }
        }
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            try
            {
                try
                {
                    if (File.Exists(e.FullPath))
                    {
                        System.Threading.Thread.Sleep(3000);//Sleeps 3 seconds so file can be fully written...
                        has_indexing = false;
                        labels = new List<List<string>>();

                        TextFieldParser parser = new TextFieldParser(e.FullPath);
                        parser.HasFieldsEnclosedInQuotes = true;
                        parser.SetDelimiters(",");
                        string[] fields;

                        while (!parser.EndOfData)
                        {
                            fields = parser.ReadFields();
                            if (has_indexing == false)
                            {
                                int c = 0;
                                foreach (var value in fields)
                                {
                                    switch (value)
                                    {
                                        case "CUST-NAME":
                                            customer_index = c;
                                            break;
                                        case "RES-PHONE":
                                            home_index = c;
                                            break;
                                        case "BUS-PHONE":
                                            business_index = c;
                                            break;
                                        case "QORD":
                                            quantity_index = c;
                                            break;
                                        case "PART-NO-1":
                                            part_index = c;
                                            break;
                                        case "DESC":
                                            desc_index = c;
                                            break;
                                        case "GRP-DV":
                                            group_index = c;
                                            break;
                                        case "PO-DATE":
                                            date_index = c;
                                            break;
                                        case "PO-NO":
                                            po_number_index = c;
                                            break;
                                        case "SO-NO":
                                            category_index = c;
                                            break;
                                    }
                                    c++;
                                }
                                has_indexing = true;
                            }

                            //NAME,                     PART NUM            QUANTITY                    HOME            BUSINESS                DESC                    GROUP               DATE            ORDER NUM               INVTORY NUM
                            labels.Add(new List<string> { fields[customer_index], fields[part_index], fields[quantity_index], fields[home_index], fields[business_index], fields[desc_index], fields[group_index], fields[date_index], fields[po_number_index], fields[category_index] });
                        }
                        parser.Close();
                        try
                        {
                            System.Threading.Thread.Sleep(300);//Sleeps 1 second
                            File.Delete(e.FullPath);
                        }
                        catch (Exception er) { logger(er.ToString()); }
                    }
                }
                catch (Exception err) { logger("Problem with getting array data " + err.ToString()); }//Probably getting an error because it fires the delete event (a file change) but then the file isn't there...

                do
                {
                    try
                    {
                        PaperSource oPSource = new PaperSource();
                        oPSource.RawKind = (int)PaperSourceKind.Manual;//Which tray...


                        PrintDocument printDoc = new PrintDocument();
                        printDoc.DefaultPageSettings.Landscape = false;
                        printDoc.DefaultPageSettings.Margins.Left = Convert.ToInt32(Properties.Settings.Default.margin_left); //100 = 1 inch = 2.54 cm
                        printDoc.DefaultPageSettings.PaperSource = oPSource;
                        printDoc.DocumentName = "Reynolds Labels"; //this can affect name of output PDF file if printer is a PDF printer
                        //printDoc.PrinterSettings.PrinterName = "MARKETING (HP Color LaserJet MFP M577)";//Connect by printer name I believe this hsould work for Lexmark Univ/Lexmark net 506 ect...
                        printDoc.PrinterSettings.PrinterName = Properties.Settings.Default.printer;//Connect by printer name I believe this hsould work for Lexmark Univ/Lexmark net 506 ect...

                        printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

                        printDoc.Print();
                    }
                    catch (Exception err) { logger("Problem with printing array " + err.ToString()); }

                } while (more_pages == true);

            }
            catch (Exception er)
            {
                logger(er.ToString());
            }
            


        }
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                textToPrint = "";
                label_count = 1;
                more_pages = false;

                foreach (List<string> subList in labels)
                {
                    //if (label_count == 1 && more_pages == false) { label_count++; continue; }//Skip first row...
                    if (label_count == 13)
                    {
                        label_count = 1;
                        labels.RemoveRange(0, 11);
                        more_pages = true;
                        break;
                    }
                    else
                    {
                        textToPrint += String.Format(
                        "CUST: {0} \nHOME: {1} WORK: {2} \n({3})-   {4}  {5} {6}\nODate: {7} ORD#: {8} INV/RO#: {9}",
                        subList[0], subList[3], subList[4], subList[2], subList[1], subList[5], subList[6], subList[7], subList[8], subList[9]);

                        for (int i = 0; i < Properties.Settings.Default.lines; i++)
                        {
                            textToPrint += "\n";
                        }
                        more_pages = false;
                        label_count++;
                    }

                }

                Graphics g = e.Graphics;

                Font font = new Font(Properties.Settings.Default.font, Convert.ToInt32(Properties.Settings.Default.font_size));
                int x1 = e.MarginBounds.Left;
                int y1 = e.MarginBounds.Top + Convert.ToInt32(Properties.Settings.Default.margin_top);

                //g.DrawRectangle(Pens.Red, x1, y1, w, h); //draw a rectangle around the margins of the page, also we can use: g.DrawRectangle(Pens.Red, e.MarginBounds)
                g.DrawString(textToPrint, font, Brushes.Black, x1, y1);
                e.HasMorePages = false; //set to true to continue printing next page
            }
            catch (Exception er) { logger(er.ToString()); }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                watch();
                print_combo.Items.Clear();

                fold_path_txt.Text = Properties.Settings.Default.path;
                print_combo.SelectedText = Properties.Settings.Default.printer;
                font_size_digit.Value = Convert.ToDecimal(Properties.Settings.Default.font_size);
                font_combo.SelectedText = Properties.Settings.Default.font;

                margin_top_digit.Value = Properties.Settings.Default.margin_top;
                margin_left_digit.Value = Properties.Settings.Default.margin_left;
                lines_digit.Value = Properties.Settings.Default.lines;
                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    print_combo.Items.Add(printer);//Load printers into printer combo box.
                }
                this.Visible = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
            catch (Exception er) { logger(er.ToString()); }

        }
        private void watch_btn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                fold_path_txt.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            bool save = true;


            if (System.IO.Directory.Exists(fold_path_txt.Text)) { Properties.Settings.Default.path = fold_path_txt.Text; }
            else { MessageBox.Show("Folder path could not be found, please set a valid folder path and try again."); save = false; }

            try { Properties.Settings.Default.printer = print_combo.Text; }
            catch (Exception er) { MessageBox.Show("Invalid printer selection, please try again.\n" + er.ToString()); save = false; }

            try { Properties.Settings.Default.font = font_combo.Text; }
            catch (Exception er) { MessageBox.Show("Invalid font selection, please try again.\n" + er.ToString()); save = false; }

            try { Properties.Settings.Default.font_size = Convert.ToInt32(font_size_digit.Value); }
            catch (Exception er) { MessageBox.Show("Invalid font size, please try again.\n" + er, ToString()); save = false; }

            try
            {
                Properties.Settings.Default.margin_left = margin_left_digit.Value;

                Properties.Settings.Default.margin_top = margin_top_digit.Value;

                Properties.Settings.Default.lines = Convert.ToInt32(lines_digit.Value);
            }
            catch (Exception er) { MessageBox.Show("Problem in the margins. Please ensure all inputs are correct.\n" + er.ToString()); save = false; }


            Properties.Settings.Default.Save();

            if (save)
            {
                MessageBox.Show("All Settings saved!");
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Visible = true;

            this.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            print_combo.Items.Clear();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                print_combo.Items.Add(printer);//Load printers into printer combo box.
            }
        }
        private void printer_test_btn_Click(object sender, EventArgs e)
        {
            PaperSource oPSource = new PaperSource();
            oPSource.RawKind = (int)PaperSourceKind.Manual;//Which tray...
            //oPSource.RawKind = (int)PaperSourceKind.AutomaticFeed;


            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = false;
            printDoc.DefaultPageSettings.Margins.Left = Convert.ToInt32(Properties.Settings.Default.margin_left); //100 = 1 inch = 2.54 cm
            printDoc.DefaultPageSettings.PaperSource = oPSource;
            printDoc.DocumentName = "My Document Name"; //this can affect name of output PDF file if printer is a PDF printer
            //printDoc.PrinterSettings.PrinterName = "MARKETING (HP Color LaserJet MFP M577)";//Connect by printer name I believe this hsould work for Lexmark Univ/Lexmark net 506 ect...
            printDoc.PrinterSettings.PrinterName = Properties.Settings.Default.printer;//Connect by printer name I believe this hsould work for Lexmark Univ/Lexmark net 506 ect...

            printDoc.PrintPage += new PrintPageEventHandler(test_printDoc_PrintPage);

            printDoc.Print();
        }
        int count = 4;
        void test_printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            //Customer name, PO, Home #, Work #, Quantity, Part Number, description, Group, order date, Ordre Number(PO), SO-NO (inventory/RO#)
            string textToPrint = String.Format("CUST: {0} PO#: {1}\nHOME: {2} WORK: {3} \n({4})-   {5}  {6} {7}\nODate: {8} ORD#: {9} INV/RO#: {10}",
                "COL-A", count.ToString(), "COL-E", "COL-F", "COL-D", "COL-C", "COL-N", "COL-O", "COL-K", "COL-P", "COL-H");
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < Properties.Settings.Default.lines; j++)
                {
                    textToPrint += "\n";
                }
                textToPrint += String.Format("CUST: {0} PO#: {1}\nHOME: {2} WORK: {3} \n({4})-   {5}  {6} {7}\nODate: {8} ORD#: {9} INV/RO#: {10}",
                    "COL-A", count.ToString(), "COL-E", "COL-F", "COL-D", "COL-C", "COL-N", "COL-O", "COL-K", "COL-P", "COL-H");
            }

            Font font = new Font(Properties.Settings.Default.font, Convert.ToInt32(Properties.Settings.Default.font_size));
            // e.PageBounds is total page size (does not consider margins)
            // e.MarginBounds is the portion of page inside margins
            int x1 = e.MarginBounds.Left;
            int y1 = e.MarginBounds.Top + Convert.ToInt32(Properties.Settings.Default.margin_top);

            //g.DrawRectangle(Pens.Red, x1, y1, w, h); //draw a rectangle around the margins of the page, also we can use: g.DrawRectangle(Pens.Red, e.MarginBounds)
            g.DrawString(textToPrint, font, Brushes.Black, x1, y1);
            e.HasMorePages = false; //set to true to continue printing next page
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Visible = false;
            }
        }

    }
}
