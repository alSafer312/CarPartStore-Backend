using System.Security.Cryptography;

namespace CarPartStore.Extensions
{
    public static class StringExtension
    {

        public static byte[] salt = System.Text.Encoding.UTF8.GetBytes("Salt_from_St'Petersburg");
        public static byte[] ConvertToHash(this string value)
        {
            CreatePasswordHash(value, out byte[] PasswordHash, salt);
            return PasswordHash;
        }
        
        private static void CreatePasswordHash(string password, out byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                hmac.Key = passwordSalt;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        public static bool TrustTo(this string password, byte[] passwordHash)
        {
            using (var hmac = new HMACSHA512(salt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

    }
}
