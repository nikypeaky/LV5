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

            Console.WriteLine($"Total price: {BiggerBox.Price}");
            Console.WriteLine($"Total weight: {BiggerBox.Weight}");
            Console.WriteLine(BiggerBox.Description());
        }
    }
}
