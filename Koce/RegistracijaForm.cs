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
    public partial class RegistracijaForm : Form
    {
        List<kraj> kraji = new List<kraj>();

        public RegistracijaForm()
        {
            InitializeComponent();

            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT id_k, ime_k, posta_k FROM vsikrajiinposta()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(1) + " " + reader.GetString(2));

                    kraj a = new kraj(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));

                    kraji.Add(a);
                }
                con.Close();
            }
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

        private void register_Click(object sender, EventArgs e)
        {
            int id = kraji[comboBox1.SelectedIndex].id;
            string pass = CreateMD5(geslo_text.Text);

            string ualin = "";

            if (IsValidEmail(email_text.Text))
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT registriraj('" + ime_text.Text + "', '" + priimek_text.Text + "', '" + email_text.Text + "', '" + pass + "', " + id + ", '" + tel_text.Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        ualin = reader.GetString(0);
                    }
                    con.Close();
                }

                if (ualin == "uspesno")
                {
                    MessageBox.Show("Registracija uspesna");

                    this.Hide();

                    PrijavaForm a = new PrijavaForm();

                    a.Show();
                }

                else
                {
                    MessageBox.Show("Registracija neuspesna");
                }
            }

            else
            {
                MessageBox.Show("Email ni validnega formata");
            }
        }
    }
}
