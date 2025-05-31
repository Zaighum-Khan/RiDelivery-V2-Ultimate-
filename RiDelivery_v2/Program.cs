namespace RiDelivery_v2
{

    class Demo
    {
        public static void Main()
        {
            User user1 = new Rider();
            user1.GetUserDetails();

            Console.WriteLine(((Rider)user1).Vehicle);
        }
    }

}