namespace DbEf6Npg
{
    public class User
    {
        public User()
        {
        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}