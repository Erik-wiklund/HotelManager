namespace HotelManager
{
    public class Customer : Person
    {
        public Customer(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}