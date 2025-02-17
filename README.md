
OVERVIEW
Display authors table as a form from a database, to contain a text box button, allows the user to search for the last name  including a label to identify the label box.

PROCESSING LOGIC
The logic that will be used is a form for the user to search the last name of the author from a form box that a database has the last name of the authors with ISBN for the user to also look up as well.

DATA (INPUT/OUTPUT)
The logical and physical data structure of files should be defined in detail. Data structure definitions must include the:
description of each element, e.g. name, type, dimension;
relationships between the elements, i.e. the structure and source;
range of possible values of each element;
initial values of each element.

COMPONENTS (SOURCE CODE NAMES, CLASSES, METHODS)
Author (model) 
represents an author in the database
attributes  authorID, FirstName: string Lastname: string
methods: tostring () : string  (optional for displaying in the ui)
author repository (data access layer)
getallauthors() : List<Author>
MainForm (UI)
a public class for author ID, by FirstName, LastName. but also the ISBN for looking up the number as well of the author.
and then another class for the database to call from to retrieve all of the information of the author’s first, and last name, but also the ISBN of the author.
TESTING
 the outcome that should be the only from entering the authors last name should be the author that the user is looking for when searching for it but also if the -database could not find the author when user input the last name of the author is incorrect.

AY 2023-24 DM
