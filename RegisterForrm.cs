using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Auth.Providers;
using XSystem.Security.Cryptography;

namespace WinFormsApp2
{
    public partial class RegisterForrm : Form
    {

        IFirebaseConfig Config = new FirebaseConfig()
        {
            AuthSecret = "hxglBMLQcKSQOCgpilSc62e9CXJpA51q8rBeLUGw",
            BasePath = "https://uber-ola-and-indrive-clo-2b5a0-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public RegisterForrm()
        {
            InitializeComponent();
        }

        private void btRegis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmail.Text) && string.IsNullOrEmpty(txbFullName.Text) && string.IsNullOrEmpty(txbPassword.Text))
            {
                MessageBox.Show("Hay dien du thong tin");

            }

            string md5Password = MD5Hash(Base64Encode(txbPassword.Text));

            User user = new User()
            {
                id = Guid.NewGuid().ToString(),
                username = txbEmail.Text,
                password = md5Password,
                fullName = txbFullName.Text,
                phone = txbPhone.Text
            };
            SetResponse set = client.Set(@"callcenters/" + user.username, user);
            MessageBox.Show("Successfully registed");
            this.Close();

        }

        private void RegisterForrm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(Config);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.ToString()}");
            }
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            var md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
