using static System.Console;

namespace HotelManager
{
    public class Menus
    {
        public void PrintHotelMenu()
        {
            Clear();
            WriteLine("- [1] Customer");
            WriteLine("- [2] Employee login");
            WriteLine("- [Q] Quit \n");
        }

        public void PrintCustomerMenu()
        {
            Clear();
            WriteLine("- [1] Book room");
            WriteLine("- [2] Leave review");
            WriteLine("- [3] See reviews");
            WriteLine("- [Q] Go back \n");
        }

        public void PrintCustomerBookingMenu()
        {
            Clear();
            WriteLine("What kind of room do you want to book: ");
            WriteLine("- [1] Basic");
            WriteLine("- [2] Moderate");
            WriteLine("- [3] Luxury");
            WriteLine("- [4] See available rooms");
            WriteLine("- [Q] Go back \n");
        }

        public void PrintEmployeeMenu()
        {
            Clear();
            WriteLine("- [1] Check in/out customer");
            WriteLine("- [2] Show rooms in hotel");
            WriteLine("- [3] Add room to hotel");
            WriteLine("- [4] Delete room from hotel");
            WriteLine("- [5] Search for booking");
            WriteLine("- [Q] Go back \n");
        }

        public void PrintEmployeeCheckInOutMenu()
        {
            Clear();
            WriteLine("- [1] Check in customer");
            WriteLine("- [2] Check out customer");
            WriteLine("- [Q] Go back \n");
        }

        public void PrintPauseMenu()
        {
            WriteLine("\nPress any key to continue");
            ReadKey();
            Clear();
        }
    }
}