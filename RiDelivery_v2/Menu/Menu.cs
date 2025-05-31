

namespace RiDelivery_v2
{
    public static class Menu
    {

        public static void DisplayMenu()
        {
            
            Console.WriteLine("Welcome To RiDelivery, Better Than Before!");
            Thread.Sleep(2000);

            Console.Clear();

            Console.Write("1. Register \n2. Login \n3. Exit");
            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    RegisterMenu();
                    break;
                case "2":
                    // LoginMenu();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1500);
                    DisplayMenu();
                    break;
            }
        }

        public static void RegisterMenu()
        {
            Console.Clear();
            Console
            .Write("1. Register as a User \n2. Register as a Rider\n3. Register as a Provider \n4. Exit \n5. Go Back");
            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    User customer = new Customer();
                    customer.GetUserDetails();
                    break;

                case "2":
                    User rider = new Rider();
                    rider.GetUserDetails();
                    break;

                case "3":
                    while (true)
                    {
                        Console.WriteLine("1. Register Restaurant \n2. Register Shop");
                        if (int.TryParse(Console.ReadLine(), out int choice2))
                        {
                            if (choice2 == 1)
                            {
                                Provider restaurant = new Restaurant();
                                restaurant.GetUserDetails();
                                break;
                            }
                            else if (choice2 == 2)
                            {
                                Provider shop = new Shop();
                                shop.GetUserDetails();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input!");
                            Thread.Sleep(1500);
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                case "5":
                    DisplayMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1500);
                    RegisterMenu();
                    break;
            }
        }

//         public static void LoginMenu()
//         {
//             Console.Clear();
//             Console.Write("1. Login as a User \n2. Login as a Rider \n3. Login as a Provider \n4. Exit \n5. Go Back");
//             Console.Write("\nEnter your choice: ");
//             string choice = Console.ReadLine() ?? "";
//             switch (choice)
//             {
//                 case "1":
//                     UserManager.CustomerLogin();
//                     break;
//                 case "2":
//                     RiderManager.riderLogin();
//                     break;
//                 case "3":
//                     string returner = RestaurantorShop.whatBusiness();
//                     if (returner == "restaurant")
//                     {
//                         RestaurantEnlisterManager.restaurantLogin();
//                     }
//                     else if (returner == "shop")
//                     {
//                         ShopEnlisterManager.shopLogin();
//                     }
//                     break;
//                 case "4":
//                     Console.WriteLine("Exiting the program. Goodbye!");
//                     break;
//                 case "5":
//                     DisplayMenu();
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     Thread.Sleep(1500);
//                     LoginMenu();
//                     break;
//             }
//         }
    }
}