
namespace BankingApp.Listner
{
    public class AccountListners
    {
        public AccountListners() { }

        public void DeactivateAccount(object ? sender,EventArgs e) 
        {
            Console.WriteLine("Your Account Is Deactivated");
        }
    }
}
