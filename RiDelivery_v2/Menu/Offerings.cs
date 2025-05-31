
namespace RiDelivery_v2
{
    public class Offering
    {
        public List<Product> Offerings { get; set; } = [];

        public void AddProducts()
        {
            Console.WriteLine("Enter the Number Of Items you want to Add: ");
            if (int.TryParse(Console.ReadLine(), out int noOfItems) && noOfItems >= 0)
            {
                if (noOfItems > 0)
                {
                    for (int i = 0; i < noOfItems; i++)
                    {
                        Console.WriteLine("\nAdding Product no.: " + (i + 1));
                        while (true)
                        {
                            Console.WriteLine("\nEnter your Product Name: ");
                            string name = Console.ReadLine() ?? "";
                            if (Validator.ValidateName(name))
                            {
                                Console.WriteLine("Enter Price: ");
                                if (double.TryParse(Console.ReadLine(), out double price) && price >= 0)
                                {
                                    Offerings.Add(new Product(name, price));
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input! Price must be a Positive Value!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input! Product Name must have a Non-Empty Value!");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Input is 0, you can go back!");
                }

            }
            else
            {
                Console.WriteLine("Invalid Input! Must be a Positive Value!");
            }
        }

    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        // testing VC
    }
}