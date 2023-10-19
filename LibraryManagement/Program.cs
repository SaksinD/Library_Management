using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a list to store books
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();
        List<LendBook> lendbooks = new List<LendBook>();

        string menu = @"
        -------------------------
        Library Management System
        -------------------------
            Select an option    
        -------------------------
        1  : Add a book
        2  : Register Members
        3  : Remove Books
        4  : Remove Members
        5  : Search Book Information
        6  : Search Member Information
        7  : Display Book Names
        8  : Display Member Names
        9  : Lend Books
        10 : Return Books
        11 : View Lending Information
        12 : Display Overdue Books
        13 : Fine Calculation
        -------------------------
        >>>";

        Console.WriteLine(menu);

        DateTime currentDateAndTime = DateTime.Now;
        DateTime currentDate = currentDateAndTime.Date;

        while (true)
        {
            Console.Write("Enter your choice (1-13): ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        // Adding a book
                        Console.Write("Enter Book ID: ");
                        string bookID = Console.ReadLine();

                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();

                        Console.Write("Enter published year: ");
                        string year = Console.ReadLine();

                        Book newBook = new Book(bookID, title, author, year, true);
                        books.Add(newBook);

                        Console.WriteLine("Book added successfully.");

                        break;

                    case 2:
                        // Adding a member
                        Console.Write("Enter member ID: ");
                        string memberID = Console.ReadLine();

                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter age: ");
                        string age = Console.ReadLine();

                        Console.Write("Enter contact number: ");
                        string phoneNo = Console.ReadLine();

                        Console.Write("Enter email : ");
                        string email = Console.ReadLine();

                        Member newMember = new Member(memberID, name, age, phoneNo, email );
                        members.Add(newMember);

                        Console.WriteLine("Registration success.");

                        break;

                    case 3:
                        //Deletion of book
                        if(books.Count > 0){
                            Console.WriteLine("-------------------------");
                            for (int i = 0; i < books.Count; i++){
                            Console.WriteLine($"{books[i].BookID} : {books[i].Title}");
                            }

                            Console.Write("Enter the Book ID to delete : ");
                            string bookIDToDelete = Console.ReadLine();

                            bool bookFound = false;
                            for (int i = 0; i < books.Count; i++){
                                if (books[i].BookID == bookIDToDelete){
                                    books.RemoveAt(i);
                                    bookFound = true;
                                    break;
                                }
                            }
                            if (bookFound){
                                Console.WriteLine("Book deleted successfully.");
                            }
                            else{
                                Console.WriteLine("Book not found.");
                            }
                        }
                        else{
                            Console.WriteLine("Empty here.");
                            
                        }

                        break;

                    case 4:
                        //Deletion of member
                        if(members.Count > 0){
                            Console.WriteLine("-------------------------");
                            for (int i = 0; i < members.Count; i++){
                            Console.WriteLine($"{members[i].MemberID} : {members[i].Name}");
                            }

                            Console.Write("Enter member ID to delete : ");
                            string memberIDToDelete = Console.ReadLine();

                            bool memberFound = false;
                            for (int i = 0; i < members.Count; i++){
                                if (members[i].MemberID == memberIDToDelete){
                                    members.RemoveAt(i);
                                    memberFound = true;
                                    break;
                                }
                            }
                            if (memberFound){
                                Console.WriteLine("Member deleted successfully.");
                            }
                            else{
                                Console.WriteLine("Member ID not found.");
                            }
                        }
                        else{
                            Console.WriteLine("Empty here.");
                            
                        }
                        break;

                    case 5:
                        // View book info
                        if(books.Count > 0){
                            Console.WriteLine("-------------------------");
                            for (int i = 0; i < books.Count; i++){
                            Console.WriteLine($"{books[i].BookID} : {books[i].Title}");
                            }

                            Console.Write("Enter the Book ID to view info : ");
                            string bookIDtoView = Console.ReadLine();

                            bool bookFound = false;
                            for (int i = 0; i < books.Count; i++){
                                if (books[i].BookID == bookIDtoView){
                                    Console.WriteLine($"Book ID: {books[i].BookID}");
                                    Console.WriteLine($"Title: {books[i].Title}");
                                    Console.WriteLine($"Author: {books[i].Author}");
                                    Console.WriteLine($"Year of published : {books[i].PublishedYear}");
                                    Console.WriteLine($"Availability : {books[i].Availability}");
                                    bookFound = true;
                                    break;
                                }
                            }
                            if (!bookFound){
                                Console.WriteLine("Invalid Book ID");
                                
                            }

                        }
                        else{
                            Console.WriteLine("Empty here.");
                        }
                        break;

                    case 6:
                        // View member info
                        if(members.Count > 0){
                            Console.WriteLine("-------------------------");
                            for (int i = 0; i < members.Count; i++){
                            Console.WriteLine($"{members[i].MemberID} : {members[i].Name}");
                            }

                            Console.Write("Enter the member ID to view info : ");
                            string memberIDtoView = Console.ReadLine();

                            bool memberFound = false;
                            for (int i = 0; i < members.Count; i++){
                                if (members[i].MemberID == memberIDtoView){
                                    Console.WriteLine($"Member ID: {members[i].MemberID}");
                                    Console.WriteLine($"Name: {members[i].Name}");
                                    Console.WriteLine($"Age: {members[i].Age}");
                                    Console.WriteLine($"Contact Number : {members[i].ContactNumber}");
                                    Console.WriteLine($"Email : {members[i].Email}");
                                    memberFound = true;
                                    break;
                                }
                            }
                            if (!memberFound){
                                Console.WriteLine("Invalid Member ID");      
                            }

                        }
                        else{
                            Console.WriteLine("Empty here.");
                        }
                        break;

                    case 7:
                    // Display Book Names
                        if(books.Count > 0){
                            for (int i = 0; i < books.Count; i++){
                                Console.WriteLine($"{i+1}. {books[i].Title}");
                            }
                        }
                        else{
                            Console.WriteLine("Empty here.");
                        }
                        break;

                    case 8:
                    //  Display Member Names
                        if(members.Count > 0){
                            for (int i = 0; i < members.Count; i++){
                                Console.WriteLine($"{i+1}. {members[i].Name}");
                            }
                        }
                        else{
                            Console.WriteLine("Empty here.");
                        }
                        break;

                    case 9:
                    //  Lend books
                    if(books.Count > 0 && members.Count > 0){

                        bool memberFound = false;
                        bool bookFound = false;
                        bool BookAvailability = false;

                        Console.WriteLine("-------------------------");
                        for (int i = 0; i < members.Count; i++){
                            Console.WriteLine($"{members[i].MemberID} : {members[i].Name}");
                        }
                        Console.Write("Enter member ID of the borrower:");
                        string memberIDofBorrower = Console.ReadLine();

                        for (int i = 0; i < members.Count; i++){
                            if (members[i].MemberID == memberIDofBorrower){
                                memberFound = true;
                                break;
                            };

                        }

                        if(!memberFound){
                            Console.Write("Member not found");
                            break;
                        }

                        Console.WriteLine("-------------------------");
                        for (int i = 0; i < books.Count; i++){
                            if(books[i].Availability){
                                Console.WriteLine($"{books[i].BookID} : {books[i].Title}");
                            }
                            
                        }

                        Console.Write("Enter Book ID :");
                        string bookIDtoLend = Console.ReadLine();

                        for (int i = 0; i < books.Count; i++){
                            if (books[i].BookID == bookIDtoLend){
                                bookFound = true;
                                books[i].Availability = false;
                                BookAvailability = true;
                                break;
                            };
                        }
                        if(!bookFound){
                            Console.Write("Book not found");
                            break;
                        }

                        if(bookFound && memberFound && BookAvailability){
                            Console.Write("Enter lend date (yy/mm/dd): ");
                            string LendDate = Console.ReadLine();

                            Console.Write("Enter return date (yy/mm/dd): ");
                            string ReturnDate = Console.ReadLine();

                            string dateFormat = "yyyy/MM/dd";

                            if ((DateTime.TryParseExact(LendDate, dateFormat, null, System.Globalization.DateTimeStyles.None, out DateTime parsedLendDate))&&(DateTime.TryParseExact(ReturnDate, dateFormat, null, System.Globalization.DateTimeStyles.None, out DateTime parsedReturnDate))){
                                LendBook l = new LendBook(memberIDofBorrower, bookIDtoLend, parsedLendDate,parsedReturnDate, false, false );
                                lendbooks.Add(l);
                                Console.Write("Details added");
                            }

                            else{
                                Console.WriteLine("Invalid date format.");
                            }
                        }
                        else{
                            Console.WriteLine("Book is not currently available");
                        }

                    }
                    break;

                    case 10:
                        //Return books

                        Console.WriteLine("-------------------------");
                        for (int i = 0; i < lendbooks.Count; i++){
                            Console.WriteLine($"Book ID : {lendbooks[i].BookID}");
                        }

                        Console.Write("Enter Book ID :");
                        string bookIDReturned = Console.ReadLine();

                        for (int i = 0; i < lendbooks.Count; i++){
                            if(lendbooks[i].BookID == bookIDReturned){
                                lendbooks[i].Returned = true;
                                break;
                            }
                        }

                        for (int i = 0; i < books.Count; i++){
                            if (books[i].BookID == bookIDReturned){
                                books[i].Availability=true ;
                                break;
                            }
                        }
                        Console.Write("Book availability has been updated");
                        break;

                    case 11:
                        for (int i = 0; i < lendbooks.Count; i++){
                            Console.WriteLine($"Book ID    : {lendbooks[i].BookID}");
                            Console.WriteLine($"Member ID  : {lendbooks[i].MemberID}");
                            Console.WriteLine($"LendDate   : {lendbooks[i].LendDate.ToShortDateString()}");
                            Console.WriteLine($"ReturnDate : {lendbooks[i].ExpectedReturnDate.ToShortDateString()}");
                            Console.WriteLine($"Returned   : {lendbooks[i].Returned}");
                            Console.WriteLine($"FinePaid   : {lendbooks[i].FinePaid}");
                            Console.WriteLine(" ");
                        }
                        break;

                    case 12:

                        for (int i = 0; i < lendbooks.Count; i++){
                            if(lendbooks[i].ExpectedReturnDate < currentDate){
                            Console.WriteLine($"Book ID    : {lendbooks[i].BookID}");
                            Console.WriteLine($"Member ID  : {lendbooks[i].MemberID}");
                            Console.WriteLine($"LendDate   : {lendbooks[i].LendDate.ToShortDateString()}");
                            Console.WriteLine($"Return Date: {lendbooks[i].ExpectedReturnDate.ToShortDateString()}");
                            Console.WriteLine($"Returned   : {lendbooks[i].Returned}");
                            //Console.WriteLine($"FinePaid   : {lendbooks[i].FinePaid}");
                            Console.WriteLine(" ");

                            }
                        }
                        break;
                    case 13:
                        for (int i = 0; i < lendbooks.Count; i++){
                            if(lendbooks[i].ExpectedReturnDate < currentDate){
                            Console.WriteLine($"Book ID    : {lendbooks[i].BookID}");
                            Console.WriteLine($"Member ID  : {lendbooks[i].MemberID}");
                            Console.WriteLine($"LendDate   : {lendbooks[i].LendDate.ToShortDateString()}");
                            Console.WriteLine($"Return Date: {lendbooks[i].ExpectedReturnDate.ToShortDateString()}");
                            TimeSpan timeDifference = currentDate - lendbooks[i].ExpectedReturnDate ;
                            int days = (int)timeDifference.TotalDays;
                            Console.WriteLine($"Overdue Days: {days} days");
                            int fine = 0;
                            if(days < 8){
                                fine += days*50;
                            }
                            else{
                                fine += 7*50 + (days-7)*100;
                            }
                            Console.WriteLine($"Fine to be paid: Rs. {fine}");
                            Console.WriteLine(" ");

                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number (1-13).");
            }

            // menu 
            Console.WriteLine(menu);

        }
    }
}
