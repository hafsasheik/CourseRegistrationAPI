using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Services
{
    public class SecurityService
    {
        public static string Encrypt(string key, string toEncrypt, bool useHashing = true)
        {
            byte[] resultArray = null;
            try
            {
                byte[] keyArray;
                byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

                if (useHashing)
                {
                    using (MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider())
                    {
                        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    }
                }
                else
                    keyArray = UTF8Encoding.UTF8.GetBytes(key);


                using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = keyArray;
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;
                    ICryptoTransform cTransform = tdes.CreateEncryptor();
                    resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string Decrypt(string key, string cipherString, bool useHashing = true)
        {
            byte[] resultArray = null;
            try
            {
                byte[] keyArray;
                byte[] toEncryptArray = Convert.FromBase64String(cipherString);

                if (useHashing)
                {
                    using (MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider())
                    {
                        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    }
                }
                else
                    keyArray = UTF8Encoding.UTF8.GetBytes(key);


                using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = keyArray;
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    ICryptoTransform cTransform = tdes.CreateDecryptor();
                    resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public static string CreateToken(int userId)
        {
            var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, SecurityService.Encrypt(AppsettingsSingleton.Instance.JwtEmailEncryption, userId.ToString())),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) //Kan användas för att kolla om jwt har blivit kopierad någon gång.
                                                                                          //Isf ska den lagras i någon cache...
                    };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AppsettingsSingleton.Instance.JwtSecret));
            var tokenCreds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddMinutes(10), signingCredentials: tokenCreds);
            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        public static string Hasher(string password, string salt)
        {
            string compHash = "";
            using (SHA256Managed sHA256Managed = new SHA256Managed())
            {
                byte[] arr = Encoding.UTF8.GetBytes(password + salt);
                byte[] hash = sHA256Managed.ComputeHash(arr);
                compHash = Convert.ToBase64String(hash);
                
            }
            return compHash;

        }
        public static string GetSalt()
        {
            string salt = "";
            using (RNGCryptoServiceProvider r = new RNGCryptoServiceProvider())
            {
                byte[] arr = new byte[16];
                r.GetNonZeroBytes(arr);
                salt = Convert.ToBase64String(arr);
            }
            return salt;
        }
    }
}
