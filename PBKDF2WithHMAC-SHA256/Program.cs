namespace PBKDF2WithHMAC_SHA256
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var passwordHasher = new PasswordHasher();

            string password = "MySecurePassword123!";
            string hashedPassword = passwordHasher.HashPassword(password);

            Console.WriteLine($"Hashed Password: {hashedPassword}");

            bool isMatch = passwordHasher.VerifyPassword("MySecurePassword123!", hashedPassword);
            Console.WriteLine($"Password match: {isMatch}");
        }
    }
}
