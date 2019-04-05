namespace TextFileDataAccessProject
{
    public class Person
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Url { get; set; }
        public string Format { get; set; }

        public Person(string firstName, string lastName, string url)
        {
            FirstName = firstName;
            LastName = lastName;
            Url = url;

            Format = $"{FirstName} {LastName}: {Url}";
        }
    }
}
