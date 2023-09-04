namespace HotelManager
{
    public class Employee : Person
    {
        public string Password { get; set; }
        
        public Employee(string name, string password) : base(name)
        {
            this.Password = password;
        }
    }
}