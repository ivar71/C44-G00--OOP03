namespace steph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[4];

            people[0] = new Student(1, "Ahmed ", "ahmed@com", 10);
            people[1] = new Student(2, "Sara ", "sara@com", 11);
            people[2] = new Teacher(3, "Mr Onizuka", "Onizuka@.com", "Mathematics");
            people[3] = new AdminStaff(4, "Fatma ", "fatma@.com", "Secretary");

            Console.WriteLine("=== School Personnel Information ===");
            foreach (var person in people)
            {
                Console.WriteLine(person.GetDetails());
            }
        }
    }
}
