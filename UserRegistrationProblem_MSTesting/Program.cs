namespace UserRegistrationProblem_MSTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistration user = new UserRegistration();
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            user.FirstNameAndLastName(firstName);
        }
    }
}