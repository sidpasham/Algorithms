Windows application where it can to parse, validate large files > 10 GB and show it in the UI GRID. For UI we used DevExpress Controls XtraGrid Control.
This is very powerful control for handling data virtualization and binding dynamic data to grid.

Once any file is drag-dropped or selected from the app, a background worker thread is created to open a Enrichment View for some user inputs. 
After the user inputs confirmation the background worker is completed and after completing, it triggers another action to parse the files.

A ParserFactory instance is created and gets the collection of all parsers available for that particular file dropped. for every of these collections each tab is created
in the grid view. Inside each instance of parser, the type of data reader is stored to read the file. 

A background thread is started to get all the rowcounts of the entire file and parse the data while getting the counts. While reading the file, bookmarks are set in
bookmark manager with row start and stream position. The results are stored in List of List of Objects. Now for each of these record object parse method is called where
the data parsing is done using SuperPower library Textparser Class. given pre-defined datatypes and properties for the field, the text parser check wheather the properties
are matched or not. if not it raisers parsing error to the UI.


