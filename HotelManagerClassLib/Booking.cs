namespace HotelManager
{
    public class Booking
    {
        public Customer BookingCustomer { get; set; }
        public Room RoomBooked { get; set; }
        public bool IsCheckedIn { get; set; }

        public Booking (Customer bookingCustomer, Room roomBooked)
        {
            this.BookingCustomer = bookingCustomer;
            this.RoomBooked = roomBooked;
        }

        public override string ToString()
        {
            return $"Customer: {BookingCustomer}\nRoom number: {RoomBooked.GetRoomNumber()}";
        }
    }
}