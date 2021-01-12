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
    public partial class Form4 : Form
    {
        string ime_koce = "";
        koca takoca = new koca();
        public Form4(koca a)
        {
            InitializeComponent();

            ime_koce = a.ime;
            takoca = a;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT ime_g FROM vsegore()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    gora_combo.Items.Add(reader.GetString(0));
                }
                con.Close();
            }


            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM vrnikraj('" + ime_koce + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ime_text.Text = reader.GetString(0);
                    opis_text.Text = reader.GetString(1);

                    nadmorska_text.Text = reader.GetInt32(2).ToString();

                    int id = gora_combo.FindString(reader.GetString(3));

                    gora_combo.SelectedIndex = id;
                }
                con.Close();
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT updatekoca('" + ime_text.Text + "', '" + opis_text.Text + "'," + nadmorska_text.Text + ", '" + gora_combo.SelectedItem + "', '" + ime_koce + "');", con);

                com.ExecuteNonQuery();
                con.Close();
            }

            this.Hide();

            kocapage koca = new kocapage(takoca);

            koca.Show();
        }
    }
}
