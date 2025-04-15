namespace Programming3
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Contact(string name, string phoneNumber, string email, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        public Contact()
        {
            Name = "Бобик";
            PhoneNumber = "+79999999999";
            Email = "bibibobi@mail.com";
            Address = "Не указан";
        }
    }
}