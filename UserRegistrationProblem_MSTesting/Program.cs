namespace UserRegistrationProblem_MSTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistration user = new UserRegistration();
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(user.FirstNameAndLastName(firstName));

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine(user.FirstNameAndLastName(lastName));
        }
    }
}