using System;
using System.Collections.Generic;

namespace SDP.ViewModels
{
    public class MainWeekModel
    {
      
        public MainWeekModel()
        {

            LoadCourse(MainPage.selectedindex);
        }

     
  
        public List<WeekModel> coursecontent { get; set; }
        public List<listcourse> relatedcourse { get; set; }
        public List<aboutmodel> about_model { get; set; }

     


        public void LoadCourse(int selectedindex)

        {
            coursecontent= new List<WeekModel>();
            Listmodel model = new Listmodel();
            relatedcourse= new List<listcourse>();
            about_model = new List<aboutmodel>();
            switch (selectedindex)
            {
                case 0:
                //load course descriptions
                    about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/Samuel.jpg"), UriKind.Relative), coach_profile = "Coach Samuel, \nJava and JS , \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                //load related courses
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
               //Load course content
                coursecontent.Add(new WeekModel("0", "Week 1", "Introduction to Big Data Big data brief History Big data Overview The four dimensions of Big data - Volume, Velocity, Variety & Veracity The role of Data Scientists"));
                coursecontent.Add(new WeekModel("1", "Week 2", "Defining Big Data Introducing the Storage, MapReduce & Query Stack Cloudera Data Models: Graphs, K-Means, K-Mediod & KNN Clustering , Decision Trees, Time series Analysis Week"));
                coursecontent.Add(new WeekModel("2", "Week 3", "Overview of Big Data stores Hadoop Distributed file system (HDFS) Pig & Hive BigTable & MongoDB"));
                coursecontent.Add(new WeekModel("3", "Week 4", "8 Overview of Big Data Processing Big Data processing Architecture Using MapReduce/Hadoop for Analysing Big data Week "));
                coursecontent.Add(new WeekModel("4", "Week 5", "Using R to execute Basic Analytic methods Introduction to R programming Language Learning the R-Programming language Analysing data using R"));
                coursecontent.Add(new WeekModel("5", "Week 6", "Project!"));
                break;

                case 1:
                about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/Samuel.jpg"), UriKind.Relative), coach_profile = "Coach Samuel, \nJava and Python, \niQube Lab", desc = "Python is a widely used general-purpose, high-level programming language. Its design philosophy emphasizes code readability, and its syntax allows programmers to express concepts in fewer lines of code" });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                coursecontent.Add(new WeekModel("0", "Week 1", "INTRODUCTION TO PYTHON Python Brief History, Python Versions, Advantages & Disadvantages Installing Python Structure of a Python Program Using the interpreter Interactively Practice Project BASIC PYTHON SYNTAX Basic Syntax, comments String Operators & Expressions Numeric Operators & Expressions Simple Input & Output, the “Print” function Practice Project "));
                coursecontent.Add(new WeekModel("1", "Week 2", "FLOW CONTROL Control Flow & Syntax, Indenting Relational & Logical Operators The IF & ELSEIF Statement The WHILE loop “Break” & “Continue” The FOR LOOP Practice Project SEQUENCE DATA List Operations & Methods Tuples Sets Dictionaries, Sorting Dictionaries,Copying collections Practice Project Meeting with Coach "));
                coursecontent.Add(new WeekModel("2", "Week 3", "FUNCTIONS Syntax of function definition Function Parameters Global & Local Variables Passing Parameters & Returning Values Defining your own Function Practice Project MODULES What a Module is Standard Modules The Import Statement, Function aliases Packages"));
                coursecontent.Add(new WeekModel("3", "Week 4", "EXCEPTIONS Errors, Runtime Errors The Exception Model, The Exception Heirarchy Handling Multiple Exceptions Writing your own Exception Classes Practice Project INPUT & OUTPUT Data Streams, Acess modes Writing data to a File, Reading Data from a file Additional File Methods Using pipes as data stream Handling IO exceptions Working with directories Metadata Practice Project Meeting with Coach"));
                coursecontent.Add(new WeekModel("4", "Week 5", "CLASSES IN PYTHON Creating and Defining classes principles of Object Orientation Instance Methods, Special Methods, Inheritance, Polymorphism Practice Project REGULAR EXPRESSIONS Simple character matches Special characters, character classes Quantifiers, Grouping Greedy Matches, Match Object Practice Project Meeting with Coach"));
                coursecontent.Add(new WeekModel("5", "Week 6", "pip install -r virtual env Vagrant Builds PROJECT! Meeting with Coach"));
                break;

                case 2:
                about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/emeka.jpg"), UriKind.Relative), coach_profile = "Coach Emeka, \nLinux Admin. and VOIP Sol., \niQube Lab", desc = "The Linux Administration guide attempts to describe day-to-day administration and maintenance issues commonly faced by Linux system administrators." });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                coursecontent.Add(new WeekModel("0", "Week 1", "Overview of the Linux System Linux history Linux Distributions Linux Architecture Installing Linux (fedora) Console tools, system editors"));
                coursecontent.Add(new WeekModel("1", "Week 2", "File System Administration File System Organization File System types, File types, File permissions Creating a FileSystem, Mounting a Filesystem, unmounting a Filesystem Backup Software, Backup Examples LAB Activity Meeting with Coach"));
                coursecontent.Add(new WeekModel("2", "Week 3", ". Essential Shell Commands Basic File Manipulation Commands Directory Navigation Commands Advanced File Manipulation Commands Init, Processes & Threads LAB Activity"));
                coursecontent.Add(new WeekModel("3", "Week 4", "Users/Groups Admin Root user Defining & Adding Users & Groups Root Priviledge commands Password database, group database LAB Activity Meeting with Coach "));
                coursecontent.Add(new WeekModel("4", "Week 5", ". Basic Networking IP Networking fundamentals OSI Layers & their Protocols Routing TCP/IP TCPDump "));
                coursecontent.Add(new WeekModel("5", "Week 6", "Project! Meeting with coach"));
                break;
                case 3:
                about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/1.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nC++ and Bash, \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                coursecontent.Add(new WeekModel("0", "Week 1", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("1", "week 2", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                coursecontent.Add(new WeekModel("2", "Week 3", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("3", "Week 4", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                coursecontent.Add(new WeekModel("4", "Week 5", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("5", "Week 6", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));

                break;

                case 4:
                about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/1.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nC++ and Bash, \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                 relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                 coursecontent.Add(new WeekModel("0", "Week 1", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("1", "Week 2", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("2", "week 3", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("3", "Week 4", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("4", "Week 5", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("5", "Week 6", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));

                 break;

                case 5:
                 about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/1.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nC++ and Bash, \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                 coursecontent.Add(new WeekModel("0", "Week 1", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("1", "Week 2", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("2", "Week 3", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("3", "Week 4", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("4", "Week 5", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("5", "Week 6", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                   
                 break;

                case 6:
                 about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/wale.jpg"), UriKind.Relative), coach_profile = "Coach Wale, \nJava and php, \niQube Lab", desc = "Java is a computer programming language that is concurrent, class-based, object-oriented. write once, run anywhere (WORA), meaning that code that runs on one platform does not need to be recompiled to run on another " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                 coursecontent.Add(new WeekModel("0", "Week 1", "INTRODUCTION TO JAVA Brief History of Java Programming Language, Java Environment & Running a Java program Java program Structure Object Orientation in java programming Packages Practice Project BASICS OF JAVA Primitive Data types, Variables, Literals, constants, Assignments, Initializations, Operators The main() method Control Flow - IF, WHILE & DO statements, Switch, break, continue statements Cast & Conversions Arrays & Strings Practice project "));
                 coursecontent.Add(new WeekModel("1", "Week 2", "METHODS Arguments & parameters Passing Objects to Methods Method Overloading, Static Method Recursion & Overloading Practice project CLASSES & OBJECTS IN JAVA The basic OOP principles - What are Classes and Objects? Instance & Class Variables, Instance & Class Methods Accessing the class members, Methods returning values & Methods with Parameters Constructors and Overloaded Constructors This, Static, Final, finalize keywords Set, get & predicate methods Abstraction, Inheritance, Polymorphism, Encapsulation, Method Overriding, Associations & Delegation Practice Project"));
                 coursecontent.Add(new WeekModel("2", "Week 3", "ABSTRACTION CLASSES & INTERFACES Purpose of Interfaces Abstract Class, Extending Abstract Classes JAVA EXCEPTION HANDLING Exception Handling, the Exception hierarchy Checked vs unchecked Exceptions, Handling & Declaring Exceptions, System Exception & Application Exception Catching an Exception: Try & Catch blocks, Advertising Exception with throws Writing Custom Eceptions Practice Project"));
                 coursecontent.Add(new WeekModel("3", "Week 4", "JAVA INPUT & OUTPUT The File Class, Standard Streams File IO using Byte, Buffered & Character Stream Data Streams: Data Input Stream & Data Output stream Classes Practice Project THREADS Advantages of using threads Threads vs processes Creating threads by extending thread & implementing runnable Threads State & Problems Practice project COLLECTIONS Vectors Hashtables Enumerations Lists, Sets, Maps The Collection Class Practice Project"));
                 coursecontent.Add(new WeekModel("4", "Week 5", "NETWORKING Networking Fundamentals The Client/Server Model URLS, Sockets Practice Project "));
                 coursecontent.Add(new WeekModel("5", "Week 6", "PROJECT!"));

                 break;
                case 7:
                 about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/1.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nC++ and Bash, \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                coursecontent.Add(new WeekModel("0", "Week 1", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("1", "Week 2", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                coursecontent.Add(new WeekModel("2", "Week 3", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("3", "Week 4", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                coursecontent.Add(new WeekModel("4", "Week 5", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("5", "Week 6", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));

                break;
                case 8:
                about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/1.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nC++ and Bash, \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                 coursecontent.Add(new WeekModel("0", "Week 1", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("1", "Week 2", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("2", "week 3", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("3", "Week 4", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("4", "Week 5", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("5", "Week 6", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                break;
                
                case 9:
                about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/francis.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nLinux and Bash, \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                coursecontent.Add(new WeekModel("0", "Week 1", "INTRODUCTION TO BASH SCRIPTING (Review tasks) Bash Brief History, Advantages & Disadvantages Structure of a bash script Bash shell options SHELL SCRIPTS Command types Creating Shell scripts Running Shell Scripts BASH_ENV Practice Project"));
                coursecontent.Add(new WeekModel("1", "Week 2", "(Knowledge tasks) VARIABLES Creating & Naming variables Special characters Practice Project FLOW CONTROL Testing Commands IF statement Loops - While loops, break & continue Practice Project Meeting with Coach "));
                coursecontent.Add(new WeekModel("2", "Week 3", "(Knowledge Tasks) ARRAYS Bash Array Syntax Initializing arrays, Appending to an Array Practice Project "));
                coursecontent.Add(new WeekModel("3", "Week 4", "(Knowledge tasks) REGULAR EXPRESSIONS Regular Expressions Syntax Filters: grep, sed, awk Practice Project Meeting with Coach "));
                coursecontent.Add(new WeekModel("4", "week 5", "(Development tasks) HANDS-ON EXERCISES"));
                coursecontent.Add(new WeekModel("5", "week 6", "PROJECT!!! Meeting with Coach res for condition-testing and iteration"));

                break;
                
                case 10:
                about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/1.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nC++ and Bash, \niQube Lab", desc = "Bash is a command processor, typically run in a text window, allowing the user to type commands which cause actions. Bash can also read commands from a file, called a script." });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                coursecontent.Add(new WeekModel("0", "Week 1", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("1", "Week 2", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                coursecontent.Add(new WeekModel("2", "Week 3", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("3", "Week 4", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                coursecontent.Add(new WeekModel("4", "Week 5", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("5", "Week 6", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                break;

                case 11:
                about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/1.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nC++ and Bash, \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                coursecontent.Add(new WeekModel("0", "Week 1", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("1", "Week 2", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                coursecontent.Add(new WeekModel("2", "Week 3", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("3", "Week 4", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                coursecontent.Add(new WeekModel("4", "Week 5", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("5", "Week 6", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));

                break;

                case 12:
                about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/Samuel.jpg"), UriKind.Relative), coach_profile = "Coach Smauel, \nJava and JS, \niQube Lab", desc = "JavaScript (JS) is a dynamic computer programming language. It is most commonly used as part of web browsers, whose implementations allow client-side scripts to interact with the user, control the browser, communicate asynchronously, and alter the document content that is displayed " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                coursecontent.Add(new WeekModel("0", "Week 1", "(Review tasks) Introduction Basic JavaScript:values, variables "));
                 coursecontent.Add(new WeekModel("1", "Week 2", "(Development tasks) Control flow 'For' Loops in JavaScript 'While' Loops in JavaScript Practice Projects Functions Function Syntax Calling a Function with Arguments Practice Projects Meeting with Coaches "));
                 coursecontent.Add(new WeekModel("2", "Week 3", "(Development tasks) Data structures: Objects and Arrays Functional Programming Methods Events Practice Projects "));
                 coursecontent.Add(new WeekModel("3", "Week 4", "(Development tasks) Modularity Regular Expressions Practice Projects Meeting with Coaches WEEK "));
                 coursecontent.Add(new WeekModel("4", "Week 5", "(Development tasks) The Document-Object Model XMLHttpRequest/Ajax Introduction to javascript frameworks Web programming Writing Into HTML Output Reacting to Events DOM Manipulation Changing HTML Content Changing HTML Images Changing HTML Styles Practice Projects"));
                 coursecontent.Add(new WeekModel("5", "Week 6", "(Knowledge tasks) PROJECTS!!!"));
                 break;
               
                case 13:
                 about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/emeka.jpg"), UriKind.Relative), coach_profile = "Coach Famisa, \nPerl and VOIP sol., \niQube Lab", desc = "Perl is a family of high-level, general-purpose, interpreted, dynamic programming languages. Perl 5 is used for graphics programming, system administration, network programming, finance, bioinformatics, and other applications " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                coursecontent.Add(new WeekModel("0", "Week 1", "INTRODUCTION TO PERL Perl Brief History, Perl Versions, Advantages & Disadvantages Structure of a perl Script Using the interpreter interactively, Running a Perl script Practice Project PERL OPERATIONS Arithmetic Operators, String Operators & Assignment Operators Relational Operators & Logical Operators String Functions Practice Project "));
                coursecontent.Add(new WeekModel("1", "Week 2", "PERL VARIABLES, ARRAYS & HASHES Data types, Variable Names & Syntax Lists, Scalar & List contexts Array Concepts, Array Functions Use of push, pop, shift, sort, reverse, chop, split, join, grep, spice key words Command Line Arguments Hashes, hashes functions Practice Project CONTROL STRUCTURES IF Statements FOR, FOREACH & WHILE Loops Meeting with coach "));
                coursecontent.Add(new WeekModel("2", "Week 3", "SUBROUTINES Calling Subroutines Passing Arguments to Subroutines Returning Values from Subroutines Predefined Subroutines Practice Projects WEEK"));
                coursecontent.Add(new WeekModel("3", "Week 4", "INPUT OPERATIONS & FILE IO String literals The print, printf, sprint functions FileHandles Reading directories MODULES & PACKAGES Using and getting Modules Using Packages Creating Modules Meeting with Coach "));
                coursecontent.Add(new WeekModel("4", "Week 5", "PATTERN MATCHING & REGULAR EXPRESSIONS Regular Expression Syntax, Metacharacters Single Character Matching Multiple Character Matching The Substitution & Translation operator Practice Project PERL & CGI Introduction to CGI Using cgi.pm Module CGI Environment variables Practice Project Introduction to DBI Brief MySQL structure Meeting with Coach"));
                coursecontent.Add(new WeekModel("5", "Week 6", "PROJECT!"));

                break;

                case 14:
                about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/rotimi.jpg"), UriKind.Relative), coach_profile = "Coach Rotimi, \nC# and php, \niQube Lab", desc = "PHP is a server-side scripting language designed for web development but also used as a general-purpose programming language. PHP is used for web programming, system administration, network programming, finance, bioinformatics, and other applications" });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                coursecontent.Add(new WeekModel("0", "Week 1", "(Knowledge tasks) INTRODUCTION TO PHP PHP brief History, Versions, Advantages & Disadvantages Structure of A PHP program PHP CLI PHP BASICS How PHP Works, the php.ini file Basic PHP Syntax - PHP tags, statements, comments, PHP Functions Variables Types, Variable Names, PHP Operators Creating Dynamic pages Practice Project"));
                coursecontent.Add(new WeekModel("1", "Week 2", "(Knowledge tasks) FLOW CONTROL Conditional processing - IF statements Loops - While Loops, do-while, break & continue Practice Project ARRAYS Enumerated Arrays, Initializing Arrays, appending to an array, looping through arrays Array manipulation functions Practice Project "));
                coursecontent.Add(new WeekModel("2", "Week 3", "(Knowledge tasks) PHP & HTML FORMS HTML Forms - How HTML Forms works, Form variables String manipulation in PHP File system access and handling file uploads "));
                coursecontent.Add(new WeekModel("3", "Week 4", "(Knowledge tasks) MySQL DATABASES Database Basics MySQL Command Line Interpreter Creating a database, Modifying a database MySQL Commands Administering a database practice project "));
                coursecontent.Add(new WeekModel("4", "Week 5", "(Knowledge tasks) XML IN PHP Introduction to XML Creating XML file PHP & XML introduction to PHP frameworks AJAX IN PHP Introduction to Ajax and it’s use AJAX & PHP Practice project "));
                coursecontent.Add(new WeekModel("5", "Week 6", "PROJECT!"));

                break;

                case 15:
                about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/1.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nC++ and Bash, \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                 coursecontent.Add(new WeekModel("0", "Week 1", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("1", "Week 2", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("2", "Week 3", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("3", "Week 4", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("4", "Week 5", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("5", "Week 6", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));

                 break;
                case 16:
                 about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/1.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nC++ and Bash, \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                coursecontent.Add(new WeekModel("0", "Week 1", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("1", "Week 2", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                coursecontent.Add(new WeekModel("2", "Week 3", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("3", "Week 4", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                coursecontent.Add(new WeekModel("4", "Week 5", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                coursecontent.Add(new WeekModel("5", "Week 6", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 break;

                case 17:
                 about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/1.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nC++ and Bash, \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                 coursecontent.Add(new WeekModel("0", "Week 1", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("1", "Week 2", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("2", "Week 3", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("3", "Week 4", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("4", "Week 5", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("5", "Week 6", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));

                 break;
                case 18:
                 about_model.Add(new aboutmodel { video_uri = new Uri(String.Format("Assets/Tiles/face.mp3"), UriKind.Relative), coach_pic = new Uri(String.Format("Assets/images/1.jpg"), UriKind.Relative), coach_profile = "Coach Francis, \nC++ and Bash, \niQube Lab", desc = "Big Data has four key properties, Volume, Vleocity, Variety and veracity. Big Data in it raw form could be processed to make real time informed decisions for business " });
                relatedcourse = model.LoadRelatedCourses(MainPage.selectedindex);
                 coursecontent.Add(new WeekModel("0", "Week 1", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("1", "week 2", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("2", "Week 3", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("3", "Week 4", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                 coursecontent.Add(new WeekModel("4", "Week 5", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                 coursecontent.Add(new WeekModel("5", "Week 6", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));

                 break;
               
            };

            return  ;
        }
    }
}
