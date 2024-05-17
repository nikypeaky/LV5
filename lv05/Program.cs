using System.Collections.ObjectModel;

namespace lv05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product("laptop", 1500.99, 2.3);
            Product Product3 = new Product("lamp",30.99, 1.5);
            Product Product2 = new Product("stapler", 15.99, 0.2);

            Box box = new Box("office supplies");
            box.Add(Product2);
            box.Add(Product3);

            Box BiggerBox = new Box("Package");
            BiggerBox.Add(box);
            BiggerBox.Add(Product1);

            //zadatak 1
            Console.WriteLine($"Total price: {BiggerBox.Price}");
            Console.WriteLine($"Total weight: {BiggerBox.Weight}");
            Console.WriteLine(BiggerBox.Description());

            //zadatak 2
            ShippingService shippingService = new ShippingService(10.0);
            Console.WriteLine($"Shipping cost of product: {shippingService.CalculateShippingCost(Product1)}");
            Console.WriteLine($"Shipping cost of box: {shippingService.CalculateShippingCost(BiggerBox)}");

            /*zadatak 3
            string csvFilePath = @"C:\Users\nikol\OneDrive\Desktop\Knjiga1.csv";


            Console.WriteLine("Testing Virtual Proxy:");
            IDataset virtualProxy = new VirtualProxyDataset(csvFilePath);
            DataConsolePrinter.PrintData(virtualProxy);

             Testiranje proxyja za zaštitu
            Console.WriteLine("\nTesting Protection Proxy:");
            User user1 = User.GenerateUser("1"); 
            User user2 = User.GenerateUser("2");  

            ProtectionProxyDataset protectionProxy1 = new ProtectionProxyDataset(user1);
            ProtectionProxyDataset protectionProxy2 = new ProtectionProxyDataset(user2);

            try
            {
                Console.WriteLine("User1 Data:");
                DataConsolePrinter.PrintData(protectionProxy1);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"User1: {ex.Message}");
            }

            try
            {
                Console.WriteLine("User2 Data:");
                DataConsolePrinter.PrintData(protectionProxy2);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"User2: {ex.Message}");
            }*/

            //zadatak 5
            ITheme lightTheme = new LightTheme();
            ITheme darkTheme = new DarkTheme();

            Note reminderNote = new ReminderNote("Buy milk", lightTheme);
            reminderNote.Show();
            reminderNote.Theme = darkTheme;
            reminderNote.Show();

            //zadatak 6 
            GroupNote familyNote = new GroupNote("Family reunion", lightTheme);
            familyNote.AddMember("Ivan");
            familyNote.AddMember("Alen");
            familyNote.AddMember("Nikolina");

            GroupNote projectNote = new GroupNote("Project meeting", darkTheme);
            projectNote.AddMember("Marko");
            projectNote.AddMember("Sara");
            projectNote.AddMember("David");

            Console.WriteLine("Family Note:");
            familyNote.Show();
            Console.WriteLine("\nProject Note:");
            projectNote.Show();
        }
    }
}
