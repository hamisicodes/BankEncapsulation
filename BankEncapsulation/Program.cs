namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine($"Initial Account balance is {account.GetBalance()}");


            account.Deposit(100.50);
            Console.WriteLine($"Final Account balance is {account.GetBalance()}");
        }
    }
}
