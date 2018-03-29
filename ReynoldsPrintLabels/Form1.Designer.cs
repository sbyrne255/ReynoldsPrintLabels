namespace ReynoldsPrintLabels
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printer_test_btn = new System.Windows.Forms.Button();
            this.watch_btn = new System.Windows.Forms.Button();
            this.fold_path_txt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.font_size_digit = new System.Windows.Forms.NumericUpDown();
            this.font_lbl = new System.Windows.Forms.Label();
            this.print_combo = new System.Windows.Forms.ComboBox();
            this.font_combo = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.margin_left_digit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.margin_top_digit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lines_digit = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.font_size_digit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margin_left_digit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margin_top_digit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lines_digit)).BeginInit();
            this.SuspendLayout();
            // 
            // printer_test_btn
            // 
            this.printer_test_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printer_test_btn.Location = new System.Drawing.Point(12, 218);
            this.printer_test_btn.Name = "printer_test_btn";
            this.printer_test_btn.Size = new System.Drawing.Size(360, 23);
            this.printer_test_btn.TabIndex = 0;
            this.printer_test_btn.Text = "Test Printer";
            this.printer_test_btn.UseVisualStyleBackColor = true;
            this.printer_test_btn.Click += new System.EventHandler(this.printer_test_btn_Click);
            // 
            // watch_btn
            // 
            this.watch_btn.Location = new System.Drawing.Point(12, 12);
            this.watch_btn.Name = "watch_btn";
            this.watch_btn.Size = new System.Drawing.Size(136, 23);
            this.watch_btn.TabIndex = 1;
            this.watch_btn.Text = "Watch Folder";
            this.watch_btn.UseVisualStyleBackColor = true;
            this.watch_btn.Click += new System.EventHandler(this.watch_btn_Click);
            // 
            // fold_path_txt
            // 
            this.fold_path_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fold_path_txt.Location = new System.Drawing.Point(154, 14);
            this.fold_path_txt.Name = "fold_path_txt";
            this.fold_path_txt.Size = new System.Drawing.Size(218, 20);
            this.fold_path_txt.TabIndex = 2;
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.Location = new System.Drawing.Point(12, 247);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(360, 23);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save Settings";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // font_size_digit
            // 
            this.font_size_digit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.font_size_digit.Location = new System.Drawing.Point(154, 66);
            this.font_size_digit.Name = "font_size_digit";
            this.font_size_digit.Size = new System.Drawing.Size(218, 20);
            this.font_size_digit.TabIndex = 6;
            this.font_size_digit.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // font_lbl
            // 
            this.font_lbl.AutoSize = true;
            this.font_lbl.Location = new System.Drawing.Point(12, 68);
            this.font_lbl.Name = "font_lbl";
            this.font_lbl.Size = new System.Drawing.Size(88, 13);
            this.font_lbl.TabIndex = 7;
            this.font_lbl.Text = "Set Font Size (pt)";
            // 
            // print_combo
            // 
            this.print_combo.FormattingEnabled = true;
            this.print_combo.Location = new System.Drawing.Point(12, 39);
            this.print_combo.Name = "print_combo";
            this.print_combo.Size = new System.Drawing.Size(253, 21);
            this.print_combo.TabIndex = 9;
            // 
            // font_combo
            // 
            this.font_combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.font_combo.FormattingEnabled = true;
            this.font_combo.Items.AddRange(new object[] {
            "Courier New",
            "Helvetica ",
            "Garamond ",
            "Frutiger ",
            "Bodoni",
            "Futura",
            "Times ",
            "Akzidenz Grotesk ",
            "Officina ",
            "Gill Sans ",
            "Univers ",
            "Optima ",
            "Franklin Gothic ",
            "Bembo ",
            "Interstate ",
            "Thesis ",
            "Rockwell ",
            "Walbaum ",
            "Meta ",
            "Trinit ",
            "Din ",
            "Matrix ",
            "OCR ",
            "Avant Garde ",
            "Lucida ",
            "Sabon ",
            "Zapfino ",
            "Letter Gothic ",
            "Stone ",
            "Arnhem ",
            "Minion ",
            "Myriad ",
            "Rotis ",
            "Eurostile ",
            "Scala ",
            "Syntax ",
            "Joanna ",
            "Fleishmann ",
            "Palatino ",
            "Baskerville ",
            "Fedra ",
            "Gotham ",
            "Lexicon ",
            "Hands ",
            "Metro ",
            "Didot ",
            "Formata ",
            "Caslon ",
            "Cooper Black ",
            "Peignot ",
            "Bell Gothic ",
            "Antique Olive ",
            "Wilhelm Klngspor Gotisch ",
            "Info ",
            "Dax ",
            "Proforma ",
            "Today Sans ",
            "Prokyon ",
            "Trade Gothic ",
            "Swift ",
            "Copperplate Gothic ",
            "Blur ",
            "Base ",
            "Bell Centennial ",
            "News Gothic ",
            "Avenir ",
            "Bernhard Modern ",
            "Amplitude ",
            "Trixie ",
            "Quadraat ",
            "Neutraface ",
            "Nobel ",
            "Industria ",
            "Bickham Script ",
            "Bank Gothic ",
            "Corporate ASE ",
            "Fago ",
            "Trajan ",
            "Kabel ",
            "House Gothic 23 ",
            "Kosmik ",
            "Caecilia ",
            "Mrs Eaves ",
            "Corpid ",
            "Miller ",
            "Souvenir ",
            "Instant Types ",
            "Clarendon ",
            "Triplex ",
            "Benguiat ",
            "Zapf Renaissance ",
            "Filosofia ",
            "Chalet ",
            "Quay Sans ",
            "C zanne ",
            "Reporter ",
            "Legacy ",
            "Agenda ",
            "Bello ",
            "Dalliance ",
            "Mistral "});
            this.font_combo.Location = new System.Drawing.Point(12, 92);
            this.font_combo.Name = "font_combo";
            this.font_combo.Size = new System.Drawing.Size(360, 21);
            this.font_combo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Margin Left (100 = 1inch)";
            // 
            // margin_left_digit
            // 
            this.margin_left_digit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.margin_left_digit.DecimalPlaces = 3;
            this.margin_left_digit.Location = new System.Drawing.Point(154, 119);
            this.margin_left_digit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.margin_left_digit.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.margin_left_digit.Name = "margin_left_digit";
            this.margin_left_digit.Size = new System.Drawing.Size(218, 20);
            this.margin_left_digit.TabIndex = 11;
            this.margin_left_digit.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Margin Top (-200 for labels)";
            // 
            // margin_top_digit
            // 
            this.margin_top_digit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.margin_top_digit.DecimalPlaces = 3;
            this.margin_top_digit.Location = new System.Drawing.Point(154, 145);
            this.margin_top_digit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.margin_top_digit.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.margin_top_digit.Name = "margin_top_digit";
            this.margin_top_digit.Size = new System.Drawing.Size(218, 20);
            this.margin_top_digit.TabIndex = 13;
            this.margin_top_digit.Value = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lines Between Pritns";
            // 
            // lines_digit
            // 
            this.lines_digit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lines_digit.Location = new System.Drawing.Point(154, 171);
            this.lines_digit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lines_digit.Name = "lines_digit";
            this.lines_digit.Size = new System.Drawing.Size(218, 20);
            this.lines_digit.TabIndex = 15;
            this.lines_digit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "RRLP Is monitoring a folder";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ReyRey Label Printer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(271, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Refresh List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lines_digit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.margin_top_digit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.margin_left_digit);
            this.Controls.Add(this.font_combo);
            this.Controls.Add(this.print_combo);
            this.Controls.Add(this.font_lbl);
            this.Controls.Add(this.font_size_digit);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.fold_path_txt);
            this.Controls.Add(this.watch_btn);
            this.Controls.Add(this.printer_test_btn);
            this.Name = "Form1";
            this.Text = "Reynolds Label Printing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.font_size_digit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margin_left_digit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margin_top_digit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lines_digit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printer_test_btn;
        private System.Windows.Forms.Button watch_btn;
        private System.Windows.Forms.TextBox fold_path_txt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.NumericUpDown font_size_digit;
        private System.Windows.Forms.Label font_lbl;
        private System.Windows.Forms.ComboBox print_combo;
        private System.Windows.Forms.ComboBox font_combo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown margin_left_digit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown margin_top_digit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lines_digit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
    }
}

