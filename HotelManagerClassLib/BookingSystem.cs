using System.Collections.Generic;
using System.Linq;

namespace HotelManager
{
    public class BookingSystem
    {
        private List<Booking> bookingList = new List<Booking>();

        public List<Booking> GetBookingList()
        {
            List<Booking> BookingListReturn = new List<Booking>();
            BookingListReturn = bookingList;
            return BookingListReturn;
        }

        public void AddNewBooking(Booking newBooking)
        {
            bookingList.Add(newBooking);
        }

        public void RemoveBookingCheckout(int search)
        {
            bookingList.Remove(bookingList.Where(bookings => bookings.RoomBooked.RoomNumber == search).FirstOrDefault());
        }

        public Booking GetBooking(int search)
        {
            var booking = bookingList.Where(bookings => bookings.RoomBooked.RoomNumber == search).FirstOrDefault();

            if (booking == null)
            {
                return null;
            }

            else
            {
                return booking;
            }
        }
    }
}