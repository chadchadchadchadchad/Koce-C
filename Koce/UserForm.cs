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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM vrni_uporabnika("+ Variable.id_u +")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text = reader.GetString(0) + " " + reader.GetString(1);

                    listBox1.Items.Add("Email: " + reader.GetString(2));
                    listBox1.Items.Add("Kraj: " + reader.GetString(3));
                    listBox1.Items.Add("Telefon: " + reader.GetString(4));
                }
                con.Close();
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            this.Hide();

            SpremeniUserForm a = new SpremeniUserForm();

            a.Show();
        }

        private void odjava_Click(object sender, EventArgs e)
        {
            this.Hide();

            Variable.id_u = 0;
        }

        private void zbrisi_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT delete_uporabnik(" + Variable.id_u + ")", con);
                com.ExecuteNonQuery();
                con.Close();
            }

            this.Hide();

            Variable.id_u = 0;
        }
    }
}
