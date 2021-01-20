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
    }
}
