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
    public partial class SpremeniUserForm : Form
    {
        List<kraj> kraji = new List<kraj>();

        public SpremeniUserForm()
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

        private void SpremeniUserForm_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM vrni_uporabnika(" + Variable.id_u + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ime_text.Text = reader.GetString(0);
                    priimek_text.Text = reader.GetString(1);

                    email_text.Text = reader.GetString(2);
                    tel_text.Text = reader.GetString(4);

                    int id = comboBox1.FindString(reader.GetString(3));

                    comboBox1.SelectedIndex = id;
                }
                con.Close();
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            int id = kraji[comboBox1.SelectedIndex].id;

            if (IsValidEmail(email_text.Text))
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT spremeni_podatke("+ Variable.id_u +", '" + ime_text.Text + "', '" + priimek_text.Text + "', '" + email_text.Text + "', " + id + ", '" + tel_text.Text + "')", con);
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }

            this.Hide();

            UserForm a = new UserForm();

            a.Show();
        }
    }
}
