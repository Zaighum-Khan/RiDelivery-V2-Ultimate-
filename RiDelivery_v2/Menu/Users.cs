namespace RiDelivery_v2
{
    public abstract class User
    {
        protected string? UserName { get; set; }
        protected string? Password { get; set; }
        protected string? Name { get; set; }
        protected string? PhoneNumber { get; set; }
        protected string? Address { get; set; }

        public virtual void GetUserDetails()
        {
            while (true)
            {
                Console.WriteLine("Enter Your UserName: ");
                string userName = Console.ReadLine() ?? "";

                if (Validator.ValidateName(userName))
                {
                    UserName = userName;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Username! Please Enter a Non-Empty Value!");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter Your Password: ");
                string password = Console.ReadLine() ?? "";

                if (Validator.ValidatePassword(password))
                {
                    Password = password;
                    break;
                }
                else
                {
                    Console.WriteLine("Password Must Be Atleast 8 Characters Long and Contain Atleast 1 Symbol!");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter Your Phone Number: ");
                string phoneNumber = Console.ReadLine() ?? "";

                if (Validator.ValidatePhoneNumber(phoneNumber))
                {
                    PhoneNumber = phoneNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid! Must be 11 Digits Long!");
                }
            }

        }

    }

    public class Customer : User
    {
        public override void GetUserDetails()
        {
            Console.WriteLine("Customer Registration");
            base.GetUserDetails();
            Console.WriteLine("\nCustomer Registration Complete!");
        }
    }

    public class Rider : User
    {
        protected internal string? Vehicle { get; set; }
        protected string? PlateNumber { get; set; }

        public override void GetUserDetails()
        {
            Console.WriteLine("Rider Registration");
            base.GetUserDetails();

            while (true)
            {
                Console.WriteLine("Enter Your Vehicle: ");
                string vehicle = Console.ReadLine() ?? "";

                if (Validator.ValidateVehicle(vehicle))
                {
                    Vehicle = vehicle;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Vehicle! Only Bike and Car!");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter Your Plate Number: ");
                string plateNumber = Console.ReadLine() ?? "";

                if (Validator.ValidatePlateNumber(plateNumber))
                {
                    PlateNumber = plateNumber;
                    break;
                }
                else
                {
                    Console
                    .WriteLine("Invalid Plate Number! Must be atleast 5 characters long containing Letters and Numbers!");
                }
            }

            Console.WriteLine("\nRider Registration Complete!");
        }
    }

    public abstract class Provider : User
    {
        protected string? BusinessName { get; set; }
        protected List<string> Branches { get; set; } = new List<string>();

        public Offering Menu { get; set; } = new Offering();

        public override void GetUserDetails()
        {
            base.GetUserDetails();

            while (true)
            {
                Console.WriteLine("Enter Your Business Name: ");
                string businessName = Console.ReadLine() ?? "";

                if (Validator.ValidateName(businessName))
                {
                    BusinessName = businessName;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Business Name! Can't be Empty!");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter Number of Branches: ");
                string noOfBranches = Console.ReadLine() ?? "";

                if (int.TryParse(noOfBranches, out int branches) && branches >= 0)
                {
                    if (branches > 0)
                    {
                        for (int i = 0; i < branches; i++)
                        {
                            Console.WriteLine("Enter Branch Location: ");
                            string branchLocation = Console.ReadLine() ?? "";
                            if (Validator.ValidateName(branchLocation))
                            {
                                Branches.Add(branchLocation);
                            }
                        }
                        break;
                    }

                    else
                    {
                        Branches.Add("No Other Branches!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid! Must Contain a Positive Integer!");
                }
            }

            Menu.AddProducts();
        }
    }

    public class Restaurant : Provider
    {
        public override void GetUserDetails()
        {
            Console.WriteLine("Restaurant Registration!");
            base.GetUserDetails();
            Console.WriteLine("\nRestaurant Registration Complete!");
        }
    }

    public class Shop : Provider
    {
        public override void GetUserDetails()
        {
            Console.WriteLine("Shop Registration!");
            base.GetUserDetails();
            Console.WriteLine("\nShop Registration Complete!");
        }
    }
}

