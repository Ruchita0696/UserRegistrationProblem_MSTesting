namespace UserRegistrationProblem_MSTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistrations user = new UserRegistrations();
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(user.FirstNameAndLastName(firstName));

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine(user.FirstNameAndLastName(lastName));

            Console.WriteLine("Enter Email Id:");
            string email = Console.ReadLine();
            Console.WriteLine(user.Email(email));

            Console.WriteLine("Enter MobileNumber with country code & space between them:");
            string mobilenumber = Console.ReadLine();
            Console.WriteLine(user.MobileNumber(mobilenumber));
        }
    }
}