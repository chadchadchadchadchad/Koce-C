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
    public partial class Form5 : Form
    {
        List<gora> gore = new List<gora>();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM vsegore()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    gora a = new gora(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));

                    gora_combo.Items.Add(a.ime);

                    gore.Add(a);
                }
                con.Close();
            }

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT vnesikoca('" + ime_text.Text + "', '" + opis_text.Text + "'," + nadmorska_text.Text + ", " + gore[gora_combo.SelectedIndex].id + ", '" + ime_text + "');", con);

                com.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
