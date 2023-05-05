using System.Reflection;

namespace Expensive_Tracker
{
    class Tracker
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public int date { get; set; }
    }
    class Expensive
    {
        List<Tracker> trackers = new List<Tracker>();
       
        static int AB=0;
        public void AddTransaction()
        {
            Console.WriteLine("Enter the title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the description");
            string description = Console.ReadLine();
            Console.WriteLine("Enter the amount");
            int amount = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the date");
            int date = Convert.ToInt32(Console.ReadLine());
           
            trackers.Add(new Tracker() { Title = title, Description = description, Amount = amount, date = date });

        }
        public void ViewExpenses()
        {
            foreach (Tracker tracker in trackers)
            {
                if (tracker.Amount < 0)
                {
                    Console.WriteLine($"Title:       {tracker.Title}");
                    Console.WriteLine($"Description: {tracker.Description}");
                    Console.WriteLine($"Amount:      {tracker.Amount}");
                    Console.WriteLine($"Date:        {tracker.date}");
                    Console.WriteLine("");
                }
            }
        }
        public void ViewIncome()
        {
            foreach (Tracker tracker in trackers)
            {
                if (tracker.Amount > 0)
                {
                    Console.WriteLine($"Title:       {tracker.Title}");
                    Console.WriteLine($"Description: {tracker.Description}");
                    Console.WriteLine($"Amount:      {tracker.Amount}");
                    Console.WriteLine($"Date:        {tracker.date}");
                    Console.WriteLine("");
                }
            }
        }
        public void AvailableBalance()
        {

            foreach (Tracker t in trackers)
            {
                AB = AB + t.Amount;
                
            }
           /* if (AB < 0)
            {
                AB = AB * -1;
            }
            else
            {
                AB = AB;
            }*/
            Console.WriteLine($"The Available Balance is {AB}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Expensive sc = new Expensive();
            while (true)
            {
                Console.WriteLine("1 for Add Transaction");
                Console.WriteLine("2 for View Expenses");
                Console.WriteLine("3 for View Income");
                Console.WriteLine("4 for AvailableBalance");
                Console.WriteLine("Choose the option");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            sc.AddTransaction();
                            break;
                        }
                     case 2:
                        {
                            sc.ViewExpenses(); 
                            break;
                        }
                      case 3:
                        {
                            sc.ViewIncome();
                            break;
                        }
                       case 4:
                        {
                            sc.AvailableBalance();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong Choice Entered");
                            break;
                        }
                        
                }
            }
        }
    }
}