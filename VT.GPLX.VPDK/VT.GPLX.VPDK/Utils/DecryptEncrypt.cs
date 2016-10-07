using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace VT.GPLX.VPDK.Utils
{
    class DecryptEncrypt
    {
        public const string PRIVATE_KEY = "<RSAKeyValue><Modulus>lcDIE9z4TWy3FzL7Ae1Un5pq20Xhp8zoeFooDp3jZud5TMfPXMKyALwS4ctOtyfBAMD/Talj1mTLZzMfaKA5KsQzhNKFAskNrKGGUh8TEiCx/1/ur3esgSF4+whJELMvnyurvogZ1paA0u2dSaO/ov7rLmOp10MNjz5y7SW8wkk=</Modulus><Exponent>AQAB</Exponent><P>xpPj7FSsq9nXCtBv2252xIyM+Sr5s+AzAhxrdhOF77d0hBurr6DRtS7weIXHKH/jM+fnZIo47w/QUX197K1ppw==</P><Q>wQ6MuM1Sgq1Q7ntn6LBe6NNgK6xQwIekp2OgDH8BspoxLNvaC/E3vmWAexmFtEpYyorCCZ/T76htST2bAScSjw==</Q><DP>waqCY37BWGkAHP/j17IICvC4nFmZZiCGHszw0RuBSKU28ZC7BHJnk7jPtftinND9GSZWuetEU4KsvI0TPrxxiQ==</DP><DQ>XjYpei3IrDjEG/1hEe6wAlLUxbtLlQkc0wsNGcwJGg2hHdEUMWu/1kxWTLyBwR/fAMiCNIwosvWwj2Ne90sIBQ==</DQ><InverseQ>VxF87dPsDH5Lfy4dhfwm1ooirNHtMssqtMERjznW3spJJ3CP9MEu94/LiyBYNaXg0znMLASjjdEsjboSKKraaA==</InverseQ><D>BvsQmJRxYrKRqlwvBTz59+Kr3oLYbQkJQSr6uQu1IQPjTKf3y5wrzgr2Wl4u0izhO1bDz+v4gnL6ZFomuarWX0y6epVPC0j1wlNRPojk37iEd+MXSRco6Tl1ejzicGs/3bRRmGA4aGCbYknUBCeGIwILnC8RgO7CZ2bZV+QvSK0=</D></RSAKeyValue>";
        public const string PUBLIC_KEY =  "<RSAKeyValue><Modulus>lcDIE9z4TWy3FzL7Ae1Un5pq20Xhp8zoeFooDp3jZud5TMfPXMKyALwS4ctOtyfBAMD/Talj1mTLZzMfaKA5KsQzhNKFAskNrKGGUh8TEiCx/1/ur3esgSF4+whJELMvnyurvogZ1paA0u2dSaO/ov7rLmOp10MNjz5y7SW8wkk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        public const string OLD_KEY    =  "<RSAKeyValue><Modulus>lcDIE9z4TWy3FzL7Ae1Un5pq20Xhp8zoeFooDp3jZud5TMfPXMKyALwS4ctOtyfBAMD/Talj1mTLZzMfaKA5KsQzhNKFAskNrKGGUh8TEiCx/1/ur3esgSF4+whJELMvnyurvogZ1paA0u2dSaO/ov7rLmOp10MNjz5y7SW8wkk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        public static string Encrypt(string password)
        {
            try
            {
                return Convert.ToBase64String(Encrypt(OLD_KEY, ConvertPasswordToByte(password)));
            }
            catch //(Exception ex)
            {
                return string.Empty;
            }
        }
        public static string Decrypt(string stringDecrypt)
        {
            try
            {
                return ConvertPasswordToString(Decrypt("<RSAKeyValue><Modulus>lcDIE9z4TWy3FzL7Ae1Un5pq20Xhp8zoeFooDp3jZud5TMfPXMKyALwS4ctOtyfBAMD/Talj1mTLZzMfaKA5KsQzhNKFAskNrKGGUh8TEiCx/1/ur3esgSF4+whJELMvnyurvogZ1paA0u2dSaO/ov7rLmOp10MNjz5y7SW8wkk=</Modulus><Exponent>AQAB</Exponent><P>xpPj7FSsq9nXCtBv2252xIyM+Sr5s+AzAhxrdhOF77d0hBurr6DRtS7weIXHKH/jM+fnZIo47w/QUX197K1ppw==</P><Q>wQ6MuM1Sgq1Q7ntn6LBe6NNgK6xQwIekp2OgDH8BspoxLNvaC/E3vmWAexmFtEpYyorCCZ/T76htST2bAScSjw==</Q><DP>waqCY37BWGkAHP/j17IICvC4nFmZZiCGHszw0RuBSKU28ZC7BHJnk7jPtftinND9GSZWuetEU4KsvI0TPrxxiQ==</DP><DQ>XjYpei3IrDjEG/1hEe6wAlLUxbtLlQkc0wsNGcwJGg2hHdEUMWu/1kxWTLyBwR/fAMiCNIwosvWwj2Ne90sIBQ==</DQ><InverseQ>VxF87dPsDH5Lfy4dhfwm1ooirNHtMssqtMERjznW3spJJ3CP9MEu94/LiyBYNaXg0znMLASjjdEsjboSKKraaA==</InverseQ><D>BvsQmJRxYrKRqlwvBTz59+Kr3oLYbQkJQSr6uQu1IQPjTKf3y5wrzgr2Wl4u0izhO1bDz+v4gnL6ZFomuarWX0y6epVPC0j1wlNRPojk37iEd+MXSRco6Tl1ejzicGs/3bRRmGA4aGCbYknUBCeGIwILnC8RgO7CZ2bZV+QvSK0=</D></RSAKeyValue>", Convert.FromBase64String(stringDecrypt)));
            }
            catch //(Exception ex)
            {
                return string.Empty;
            }
        }
        private static byte[] Decrypt(string privatekey, byte[] decrypted)
        {
            byte[] rgb = decrypted;
            try
            {
                RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(new CspParameters()
                {
                    ProviderType = 1
                });
                cryptoServiceProvider.FromXmlString(privatekey);
                return cryptoServiceProvider.Decrypt(rgb, false);
            }
            catch //(Exception ex)
            {
                return (byte[])null;
            }
        }
        private static string ConvertPasswordToString(byte[] arrByte)
        {
            try
            {
                return new UnicodeEncoding().GetString(arrByte);
            }
            catch //(Exception ex)
            {
                return string.Empty;
            }
        }
        public static byte[] ConvertPasswordToByte(string s)
        {
            try
            {
                return new UnicodeEncoding().GetBytes(s);
            }
            catch //(Exception ex)
            {
                return new byte[0];
            }
        }
        private static byte[] Encrypt(string publickey, byte[] encrypted)
        {
            byte[] rgb = encrypted;
            try
            {
                RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(new CspParameters()
                {
                    ProviderType = 1
                });
                cryptoServiceProvider.FromXmlString(publickey);
                return cryptoServiceProvider.Encrypt(rgb, false);
            }
            catch //(Exception ex)
            {
                return (byte[])null;
            }
        }
    }
}
