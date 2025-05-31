namespace RiDelivery_v2
{
    class Validator
    {

        public static bool ValidateName(string userName)
        {
            return !string.IsNullOrWhiteSpace(userName);
        }

        public static bool ValidatePassword(string password)
        {
            string symbols = "!@#$%^&*()_+-=[]{}\\|?/,.<>`~;\"";
            return password.Length > 7 && password.Any(symbols.Contains);
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 11 && !string.IsNullOrEmpty(phoneNumber) && phoneNumber.All(char.IsDigit);
        }

        public static bool ValidateVehicle(string vehicle)
        {
            return vehicle.Equals("Bike", StringComparison.OrdinalIgnoreCase) || vehicle.Equals("Car", StringComparison.OrdinalIgnoreCase);
        }

        public static bool ValidatePlateNumber(string plateNumber)
        {
            return !string.IsNullOrWhiteSpace(plateNumber)
                   && plateNumber.Length >= 5
                   && plateNumber.Any(char.IsLetter)
                   && plateNumber.Any(char.IsDigit);
        }
    }
}