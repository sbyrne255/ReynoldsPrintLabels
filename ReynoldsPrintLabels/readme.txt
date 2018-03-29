Version 1.0.4
Reynolds & Reynolds Printer Labels
Purpose:
To replace the crazy, poorly maintained, company that is Rey Rey... Rrr, wait, no, sorry we're just printing labels from here.... for now.

Known Issues:
If any fields contain extra commas, for instants "My company, inc" which gets split into another "field" instead of being just the company name... Currently there is no resolution to this problem in the software
however links like: https://stackoverflow.com/questions/6542996/how-to-split-csv-whose-columns-may-contain may provide some help, I noticed "Birch company, inc" Starts with a quote, suggesting
reynolds may be parsing their data to have all comma inclusive fields be quoted, if so, the above link will fix that... If not...........

Scope Of Program:
Due to Rey Rey cutting the label printing feature, we will now go into ERA IGNITE --> Dynamic reporting --> SPL Labels --> Enter label number --> Right click --> Export --> All Rows
Save the file in the same directory that this program is watching (to open watcher settings, click the printer icon and set the folder path). When the file is saved, 3 seconds later 
it will be parsed into 1 or more print jobs (11 labels per job), parse the information, and then print it... After it prints (or has creatde the print jobs) the file will be delete to avoid clutter.


Setup:
Install the program leaving all settings as default (install for all users, default path for install although this really doesn't matter), restart computer OR go to the startup folder and run the RRPL program
from here, you will see a gray printer in the icon tray, click it (left) to open the settings and options. Recommended is 8pt font, -200 top margin, 25 left margin, and courier font; please also
Select a valid printer from the list, refreshing if the list is empty. IF YOU CLICK THE X THE PROGRAM WILL CLOSE, IF YOU WANT IT TO KEEP RUNNING, PRESS THE MINIMZE BUTTON TO HIDE IT!
