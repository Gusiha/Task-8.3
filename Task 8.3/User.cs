namespace Task_8._3
{
    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public string GetFullInformation()
        {
            return $"Name: {Name}\n" +
                   $"Password: {Password}\n" +
                   $"Email: {Email}";
        }

        public User(string name, int age, string password, string email)
        {
            Name = name;
            Age = age;
            Password = password;
            Email = email;
        }
    }

}
