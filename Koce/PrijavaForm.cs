using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koce
{
    public partial class PrijavaForm : Form
    {
        public PrijavaForm()
        {
            InitializeComponent();
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegistracijaForm a = new RegistracijaForm();

            a.Show();
        }

        private void prijava_Click(object sender, EventArgs e)
        {
            string pass = CreateMD5(geslo_text.Text);

            int prijava = 0;

            if (IsValidEmail(email_text.Text))
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT prijava('" + email_text.Text + "', '" + pass + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        prijava = reader.GetInt32(0);
                    }
                    con.Close();
                }

                if (prijava > 0)
                {
                    MessageBox.Show("Prijava uspesna");

                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Prijava neuspesna");
                }
            }
        }
    }
}
