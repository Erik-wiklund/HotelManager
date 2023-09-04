using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace HotelManager
{
    class Program
    {
        static void Main(string[] args)
        {
            BookingSystem bookingSystem = new BookingSystem();
            Hotel hotel = new Hotel();
            hotel.CreateInitialReviews();
            hotel.CreateInitialRooms();

            bool programIsRunning = true;
            while (programIsRunning)
            {
                Menus menu = new Menus();
                menu.PrintHotelMenu();
                ConsoleKey choice;
                choice = ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.D1:

                        bool customerMenuIsRunning = true;
                        while (customerMenuIsRunning)
                        {
                            menu.PrintCustomerMenu();
                            choice = ReadKey(true).Key;
                            switch (choice)
                            {
                                case ConsoleKey.D1:

                                    bool bookingCustomerMenuIsRunning = true;
                                    while (bookingCustomerMenuIsRunning)
                                    {
                                        menu.PrintCustomerBookingMenu();
                                        choice = ReadKey(true).Key;
                                        Room bookARoom;
                                        switch (choice)
                                        {
                                            case ConsoleKey.D1:

                                                int j = 1;
                                                var basicRooms = hotel.GetRooms();
                                                bookARoom = basicRooms[j];
                                                WriteLine($"{"Room type:",-20}{"Available:",-20}{"Floor number:",-20}{"Room number:",-22}{"Beds:",-18}{"Bathrooms:",-20}{"Area size:",-20}");

                                                foreach (var item in basicRooms)
                                                {
                                                    if (basicRooms[j].roomType == RoomType.Basic && basicRooms[j].IsRoomAvailable == true)
                                                    {
                                                        WriteLine($"{basicRooms[j]}");
                                                        bookARoom = basicRooms[j];
                                                    }
                                                    j++;
                                                }
                                                WriteLine();
                                                
                                                if (bookARoom.roomType == RoomType.Basic && bookARoom.IsRoomAvailable == true)
                                                {
                                                    BookARoom(bookARoom);
                                                    bookingCustomerMenuIsRunning = false;
                                                    menu.PrintPauseMenu();
                                                }

                                                else
                                                {
                                                    WriteLine("No basic rooms available at the moment.");
                                                    WriteLine("Press enter to continue. . .");
                                                    ReadKey();
                                                }
                                                break;

                                            case ConsoleKey.D2:

                                                int k = 1;
                                                var medelRooms = hotel.GetRooms();
                                                bookARoom = medelRooms[k];
                                                WriteLine($"{"Room type:",-20}{"Available:",-20}{"Floor number:",-20}{"Room number:",-22}{"Beds:",-18}{"Bathrooms:",-20}{"Area size:",-20}");

                                                foreach (var item in medelRooms)
                                                {
                                                    if (medelRooms[k].roomType == RoomType.Moderate && medelRooms[k].IsRoomAvailable == true)
                                                    {
                                                        WriteLine($"{medelRooms[k]}");
                                                        bookARoom = medelRooms[k];
                                                    }
                                                    k++;
                                                }
                                                WriteLine();

                                                if (bookARoom.roomType == RoomType.Moderate && bookARoom.IsRoomAvailable == true)
                                                {
                                                    BookARoom(bookARoom);
                                                    bookingCustomerMenuIsRunning = false;
                                                    menu.PrintPauseMenu();
                                                }

                                                else
                                                {
                                                    WriteLine("No moderate rooms available at the moment.");
                                                    WriteLine("Press enter to continue. . .");
                                                    ReadKey();
                                                }
                                                break;

                                            case ConsoleKey.D3:

                                                int i = 1;
                                                var luxuryRooms = hotel.GetRooms();
                                                bookARoom = luxuryRooms[i];
                                                WriteLine($"{"Room type:",-20}{"Available:",-20}{"Floor number:",-20}{"Room number:",-22}{"Beds:",-18}{"Bathrooms:",-20}{"Area size:",-20}");

                                                foreach (var item in luxuryRooms)
                                                {
                                                    if (luxuryRooms[i].roomType == RoomType.Luxury && luxuryRooms[i].IsRoomAvailable == true)
                                                    {
                                                        WriteLine($"{luxuryRooms[i]}");
                                                        bookARoom = luxuryRooms[i];
                                                    }
                                                    i++;
                                                }
                                                WriteLine();

                                                if (bookARoom.roomType == RoomType.Luxury && bookARoom.IsRoomAvailable == true)
                                                {
                                                    BookARoom(bookARoom);
                                                    bookingCustomerMenuIsRunning = false;
                                                    menu.PrintPauseMenu();
                                                }

                                                else
                                                {
                                                    WriteLine("No luxury rooms available at the moment.");
                                                    WriteLine("Press enter to continue. . .");
                                                    ReadKey();
                                                }

                                                break;

                                            case ConsoleKey.D4:

                                                Dictionary<int, Room> rooms = hotel.GetRooms();
                                                var availableRooms = hotel.GetListOfAvailableRooms<string>(rooms);

                                                Write("\n");
                                                WriteLine($"{"Room type:",-20}{"Available:",-20}{"Floor number:",-20}{"Room number:",-22}{"Beds:",-18}{"Bathrooms:",-20}{"Area size:",-20}");
                                                foreach (var item in availableRooms)
                                                {
                                                    WriteLine(item);
                                                }
                                                menu.PrintPauseMenu();
                                                break;

                                            case ConsoleKey.Q:
                                                bookingCustomerMenuIsRunning = false;
                                                break;
                                        }
                                    }
                                    break;

                                case ConsoleKey.D2:

                                    float newReview = CheckReviewNumberInput();
                                    hotel.AddNewReview(newReview);
                                    WriteLine();
                                    WriteLine("Thank you for leaving a review!");
                                    menu.PrintPauseMenu();
                                    break;

                                case ConsoleKey.D3:
                                    WriteLine($"The average review score is: {hotel.GetAverageReview()}");
                                    WriteLine();
                                    menu.PrintPauseMenu();
                                    break;

                                case ConsoleKey.Q:
                                    customerMenuIsRunning = false;
                                    break;
                            }
                        }
                        break;

                    case ConsoleKey.D2:

                        bool employeeMenuisRunning = true;
                        LoginEmployee();
                        while (employeeMenuisRunning)
                        {
                            menu.PrintEmployeeMenu();
                            choice = ReadKey(true).Key;
                            switch (choice)
                            {
                                case ConsoleKey.D1:
                                    bool employeeSubMenuIsRunning = true;
                                    while (employeeSubMenuIsRunning)
                                    {
                                        menu.PrintEmployeeCheckInOutMenu();
                                        choice = ReadKey(true).Key;
                                        switch (choice)
                                        {
                                            case ConsoleKey.D1:

                                                bool bookingWasFound = false;
                                                WriteLine("Search for Booking by room number");
                                                Write(":>");
                                                int bookingRoomNr = CheckIntInput();
                                                var foundBooking = bookingSystem.GetBooking(bookingRoomNr);

                                                if (foundBooking == null)
                                                {
                                                    WriteLine("No booking was found");
                                                    menu.PrintPauseMenu();
                                                    break;
                                                }

                                                else
                                                {
                                                    WriteLine($"Booking match: \n{foundBooking}");

                                                    if (foundBooking.IsCheckedIn == true)
                                                    {
                                                        WriteLine("Customer has already checked in.");
                                                    }

                                                    else
                                                    {
                                                        WriteLine("Do you want to check in the customer for this booking? Y/N");
                                                        choice = ReadKey(true).Key;
                                                        bookingWasFound = true;
                                                    }
                                                }

                                                if (choice == ConsoleKey.Y && bookingWasFound == true)
                                                {
                                                    foundBooking.IsCheckedIn = true;
                                                    WriteLine($"{foundBooking.BookingCustomer} was checked in to {foundBooking.RoomBooked.RoomNumber}");
                                                    foundBooking.RoomBooked.IsRoomAvailable = true;
                                                }

                                                else if (choice == ConsoleKey.N && bookingWasFound == true)
                                                {
                                                    WriteLine("Customer will not be checked in yet.");
                                                }
                                                menu.PrintPauseMenu();
                                                break;

                                            case ConsoleKey.D2:

                                                bookingWasFound = false;
                                                WriteLine("Search for Booking");
                                                Write(":>");
                                                bookingRoomNr = CheckIntInput();
                                                foundBooking = bookingSystem.GetBooking(bookingRoomNr);

                                                if (foundBooking == null)
                                                {
                                                    WriteLine("No booking was was found");
                                                    menu.PrintPauseMenu();
                                                    break;
                                                }

                                                else
                                                {
                                                    WriteLine($"Booking match: \n{foundBooking}");

                                                    if (foundBooking.IsCheckedIn == true)
                                                    {
                                                        WriteLine("Do you want to check out the customer for this booking? Y/N");
                                                        choice = ReadKey(true).Key;
                                                        bookingWasFound = true;
                                                    }

                                                    else
                                                    {
                                                        WriteLine("No booking found.");
                                                    }
                                                }

                                                if (choice == ConsoleKey.Y && bookingWasFound == true)
                                                {

                                                    foundBooking.IsCheckedIn = false;
                                                    WriteLine($"{foundBooking.BookingCustomer} was checked out from {foundBooking.RoomBooked.RoomNumber}");
                                                    bookingSystem.RemoveBookingCheckout(bookingRoomNr);
                                                }

                                                else if (choice == ConsoleKey.N && bookingWasFound == true)
                                                {
                                                    WriteLine("Customer will not be checked out yet. ");
                                                }
                                                menu.PrintPauseMenu();
                                                break;

                                            case ConsoleKey.Q:
                                                employeeSubMenuIsRunning = false;
                                                break;
                                        }
                                    }
                                    break;

                                case ConsoleKey.D2:

                                    Dictionary<int, Room> showRooms = new Dictionary<int, Room>();
                                    showRooms = hotel.GetRooms();

                                    Write("\n");
                                    WriteLine($"{"Room type:",-20}{"Available:",-20}{"Floor number:",-20}{"Room number:",-22}{"Beds:",-18}{"Bathrooms:",-20}{"Area size:",-20}");
                                    foreach (var item in showRooms)
                                    {
                                        WriteLine(item.Value);
                                    }
                                    menu.PrintPauseMenu();
                                    break;

                                case ConsoleKey.D3:

                                    WriteLine("Floor nr");
                                    Write(":>");
                                    int floorNumberInput = CheckIntInput();
                                    int roomNumberInput = 0;
                                    int areaSizeInput = 0;
                                    bool checkIfRoomIsAvailable = true;
                                    while (checkIfRoomIsAvailable)
                                    {
                                        WriteLine("Room nr");
                                        Write(":>");
                                        roomNumberInput = hotel.IsRoomNumberAvailable(CheckIntInput());
                                        if (roomNumberInput == 0)
                                        {
                                            WriteLine("That roomnumber already exists!");
                                        }
                                        else if (roomNumberInput != 0)
                                        {
                                            roomNumberInput = hotel.IsRoomNumberAvailable(roomNumberInput);
                                            checkIfRoomIsAvailable = false;
                                        }
                                    }

                                    bool checkAreaSize = true;
                                    while (checkAreaSize)
                                    {
                                        WriteLine("Area size (max 150)");
                                        Write(":>");
                                        areaSizeInput = CheckIntInput();
                                        if (areaSizeInput > 150 || areaSizeInput < 10)
                                        {
                                            WriteLine("You have to input a value between 10 and 150");
                                            menu.PrintPauseMenu();

                                        }
                                        else if (areaSizeInput <= 150 && areaSizeInput >= 10)
                                        {
                                            checkAreaSize = false;
                                        }
                                    }
                                    hotel.CreateRoom(floorNumberInput, roomNumberInput, areaSizeInput);
                                    WriteLine();
                                    WriteLine("Room added!");
                                    menu.PrintPauseMenu();
                                    break;

                                case ConsoleKey.D4:

                                    WriteLine("Room number to delete");
                                    Write(":>");
                                    int i = CheckIntInput();
                                    int roomNumber = hotel.DeleteRoom(i);
                                    WriteLine(roomNumber);

                                    if (roomNumber == 1)
                                    {
                                        WriteLine("Room number {0} was deleted!", i);
                                    }

                                    else if (roomNumber != 1)
                                    {
                                        WriteLine("Room number {0} was not found!", i);
                                    }
                                    menu.PrintPauseMenu();
                                    break;

                                case ConsoleKey.D5:
                                    SearchBooking();
                                    break;

                                case ConsoleKey.Q:
                                    employeeMenuisRunning = false;
                                    break;
                            }
                        }
                        break;

                    case ConsoleKey.Q:
                        Clear();
                        WriteLine("Exiting program.");
                        programIsRunning = false;
                        break;
                }
            }

            static int CheckReviewNumberInput()
            {
                int inputReview;
                while (true)
                {
                    WriteLine("Input a review score 1-5:");
                    Write(":>");
                    string userInput = ReadLine();
                    if (Int32.TryParse(userInput, out inputReview))
                    {
                        if (inputReview >= 1 && inputReview <= 5)
                        {
                            break;
                        }
                    }
                    else
                    {
                        WriteLine("Invalid input, type a number between 1 and 5!");
                    }
                }
                return inputReview;
            }

            static int CheckIntInput()
            {
                int inputInt;
                while (true)
                {
                    bool isInt = Int32.TryParse(ReadLine(), out inputInt);
                    if (isInt)
                    {
                        break;
                    }
                    else
                    {
                        WriteLine("You must input a number!");
                        Write(":>");
                    }
                }
                return inputInt;
            }

            static string CheckStringInput(string input)
            {
                while (true)
                {
                    if (String.IsNullOrEmpty(input))
                    {
                        WriteLine("Sorry. Please input text.");
                        input = ReadLine();
                    }
                    else
                    {
                        return input;
                    }
                }
            }

            void BookARoom(Room roomToBeBooked)
            {
                ConsoleKey choice;
                WriteLine("Do you want to book a room? Y/N");
                while (true)
                {
                    choice = ReadKey(true).Key;
                    if (choice == ConsoleKey.Y)
                    {
                        WriteLine("Input your name");
                        Write(":>");
                        string name = CheckStringInput(ReadLine());
                        WriteLine($"Room with room number {roomToBeBooked.RoomNumber} will be booked.");

                        Customer newCustomer = new Customer(name);
                        Booking booking = new Booking(newCustomer, roomToBeBooked);
                        bookingSystem.AddNewBooking(booking);
                        roomToBeBooked.IsRoomAvailable = false;
                        break;
                    }

                    else if (choice == ConsoleKey.N)
                    {
                        WriteLine();
                        WriteLine("No room will be booked.");
                        break;
                    }

                    else if (choice != ConsoleKey.N && choice != ConsoleKey.Y)
                    {
                        WriteLine("You must chose Y/N!");
                    }
                }
            }

            static void LoginEmployee()
            {
                bool successful = false;
                var employee = new Employee("admin", "admin");

                while (!successful)
                {
                    WriteLine("Enter your username");
                    Write(":>");
                    var username = ReadLine();
                    WriteLine("Enter your password");
                    Write(":>");
                    var password = ReadPassword();

                    if (username == employee.Name && password == employee.Password)
                    {
                        Clear();
                        WriteLine($"You have successfully logged in as {employee.Name}!");
                        WriteLine("Press any key to continue");
                        ReadKey();
                        successful = true;
                        break;
                    }

                    else if (!successful)
                    {
                        WriteLine("Username or password is incorrect, please try again!");
                    }
                }
            }
            // Method ReadPassword used from StackOverflow, added as last minute change
            static string ReadPassword()
            {
                string password = "";
                ConsoleKeyInfo info = Console.ReadKey(true);
                while (info.Key != ConsoleKey.Enter)
                {
                    if (info.Key != ConsoleKey.Backspace)
                    {
                        Console.Write("*");
                        password += info.KeyChar;
                    }
                    else if (info.Key == ConsoleKey.Backspace)
                    {
                        if (!string.IsNullOrEmpty(password))
                        {
                            // remove one character from the list of password characters
                            password = password.Substring(0, password.Length - 1);
                            // get the location of the cursor
                            int pos = Console.CursorLeft;
                            // move the cursor to the left by one character
                            Console.SetCursorPosition(pos - 1, Console.CursorTop);
                            // replace it with space
                            Console.Write(" ");
                            // move the cursor to the left by one character again
                            Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        }
                    }
                    info = Console.ReadKey(true);
                }
                // add a new line because user pressed enter at the end of their password
                Console.WriteLine();
                return password;
            }

            void SearchBooking()
            {
                WriteLine("Searchterm\n");
                Write(":>");
                string term = ReadLine();
                term = CheckStringInput(term);
                Int32.TryParse(term, out int term2);

                List<Booking> getBookings = new List<Booking>();
                getBookings = bookingSystem.GetBookingList();

                List<Booking> result = getBookings.FindAll(c => c.BookingCustomer.Name.Contains(term, StringComparison.OrdinalIgnoreCase) || c.RoomBooked.RoomNumber == term2);

                foreach (Booking results in result)
                {
                    WriteLine(results.ToString() + "\n");
                }

                bool tomlista = !result.Any();
                if (tomlista)
                {
                    WriteLine("There aren't any bookings containing that search term. Press any key to continue.");
                }

                else
                {
                    WriteLine("Press any key to continue.");
                }
                ReadKey();
            }
        }
    }
}