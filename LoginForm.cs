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
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using XSystem.Security.Cryptography;

namespace WinFormsApp2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        IFirebaseConfig Config = new FirebaseConfig()
        {
            AuthSecret = "hxglBMLQcKSQOCgpilSc62e9CXJpA51q8rBeLUGw",
            BasePath = "https://uber-ola-and-indrive-clo-2b5a0-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btRegis_Click(object sender, EventArgs e)
        {
            RegisterForrm reg = new RegisterForrm();
            reg.ShowDialog();
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"callcenters/" + txbEmail.Text);
            User resUser = res.ResultAs<User>();
            User currentUser = new User()
            {
                username = txbEmail.Text,
                password = MD5Hash(Base64Encode(txbPassword.Text))
            };

            if (User.IsEqual(resUser, currentUser) == true)
            {
                MainForm form = new MainForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login false");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForrm reg = new RegisterForrm();
            reg.ShowDialog();
        }
    }
}
