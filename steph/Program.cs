namespace steph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[4];

            people[0] = new Student(15, "Ahmed ", "mo", 10);
            people[1] = new Student(21, "Sara ", "Ismal", 11);
            people[2] = new Teacher(31, "Mr Onizuka", "great", "Mathematics");
            people[3] = new AdminStaff(41, "Fatma ", "hamed", "Secretary");

            Console.WriteLine("=== School Personnel Information ===");
            foreach (var person in people)
            {
                Console.WriteLine(person.GetDetails());
            }
        }
    }
}
