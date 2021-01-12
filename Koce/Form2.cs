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
    public partial class koce_form : Form
    {
        public koce_form()
        {
            InitializeComponent();
        }

        List<koca> koce = new List<koca>();

        private void kocelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kocelist.SelectedIndex == -1)
            {
                MessageBox.Show("Izberite koco!");
            }
            else
            {
                string a = kocelist.SelectedItem.ToString();

                kocapage koca = new kocapage(a);
                koca.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM vsekoce()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    koca a = new koca(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));

                    kocelist.Items.Add(a.ime);

                    koce.Add(a);
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 lep = new Form1();

            lep.Show();
        }
    }
}