using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Koce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<kraj> kraji = new List<kraj>();


        List<string> ime_g = new List<string>();

        private void update_list()
        {
            kraji.Clear();

            krajilistbox.Items.Clear();

            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT id_k, ime_k, posta_k FROM vsikrajiinposta()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    krajilistbox.Items.Add(reader.GetString(1) + " " + reader.GetString(2));

                    kraj a = new kraj(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));

                    kraji.Add(a);
                }
                con.Close();
            }

            ime_g.Clear();
            gorelistbox.Items.Clear();

            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT ime_k FROM vsegore()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    gorelistbox.Items.Add(reader.GetString(0));

                    ime_g.Add(reader.GetString(0));
                }
                con.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT ime_k FROM vsikraji()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    kraj_combo.Items.Add(reader.GetString(0));
                }
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT id_k, ime_k, posta_k FROM vsikrajiinposta()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    krajilistbox.Items.Add(reader.GetString(1) + " " + reader.GetString(2));

                    kraj a = new kraj(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));

                    kraji.Add(a);
                }
                con.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT ime_k FROM vsegore()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    gorelistbox.Items.Add(reader.GetString(0));

                    ime_g.Add(reader.GetString(0));
                }
                con.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT ime_k FROM vsikraji()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    kraj_combo.Items.Add(reader.GetString(0));
                }
                con.Close();
            }
        }

        private void krajilistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (krajilistbox.SelectedIndex == -1)
            {
                MessageBox.Show("Izberite kraj!");
            }
            else
            {
                kraj_text_kraj.Text = kraji[krajilistbox.SelectedIndex].ime;
                posta_text_kraj.Text = kraji[krajilistbox.SelectedIndex].posta;

                delete_kraj.Enabled = true;
                update_kraj.Enabled = true;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT updatekraj('"+ kraj_text_kraj.Text + "', '"+ posta_text_kraj.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }

            update_list();
            kraj_text_kraj.Text = "";
            posta_text_kraj.Text = "";

            delete_kraj.Enabled = false;
            update_kraj.Enabled = false;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT vnesikraj('" + kraj_text_kraj.Text + "', '" + posta_text_kraj.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }

            update_list();
            kraj_text_kraj.Text = "";
            posta_text_kraj.Text = "";

            delete_kraj.Enabled = false;
            update_kraj.Enabled = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT deletekraji('" + kraj_text_kraj.Text + "', '" + posta_text_kraj.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }

            update_list();
            kraj_text_kraj.Text = "";
            posta_text_kraj.Text = "";

            delete_kraj.Enabled = false;
            update_kraj.Enabled = false;
        }

        private void gorelistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gorelistbox.SelectedIndex == -1)
            {
                MessageBox.Show("Izberite goro!");
            }
            else
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT ime_g, opis_g, kraj_g FROM vrnigoro('" + gorelistbox.SelectedItem + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        ime_text_gore.Text = reader.GetString(0);

                        try
                        {
                            gore_opis.Text = reader.GetString(1);
                        }
                        catch (Exception)
                        {
                            gore_opis.Text = "";
                        }

                        int id = kraj_combo.FindString(reader.GetString(2));

                        kraj_combo.SelectedIndex = id;
                    }
                    con.Close();
                }

                updategore.Enabled = true;
                deletegore.Enabled = true;
            }
        }

        private void updategore_Click(object sender, EventArgs e)
        {
            int id = 0;

            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT id_g FROM vrnigoraid('" + gorelistbox.SelectedItem + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                con.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT updategora('"+ ime_text_gore.Text + "', '" + gore_opis.Text + "','" + kraj_combo.SelectedItem + "', " + id + ");", con);

                com.ExecuteNonQuery();
                con.Close();
            }

            update_list();

            ime_text_gore.Text = "";
            gore_opis.Text = "";

            updategore.Enabled = false;
            deletegore.Enabled = false;
        }

        private void deletegore_Click(object sender, EventArgs e)
        {
            int id = 0;

            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT id_g FROM vrnigoraid('" + gorelistbox.SelectedItem + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                con.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT deletegora(" + id + ");", con);

                com.ExecuteNonQuery();
                con.Close();
            }

            update_list();

            ime_text_gore.Text = "";
            gore_opis.Text = "";

            updategore.Enabled = false;
            deletegore.Enabled = false;
        }

        private void gorevnesi_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT vnesigoro('" + ime_text_gore.Text + "', '" + gore_opis.Text + "', '" + kraj_combo.SelectedItem + "');", con);

                com.ExecuteNonQuery();
                con.Close();
            }

            update_list();

            ime_text_gore.Text = "";
            gore_opis.Text = "";

            updategore.Enabled = false;
            deletegore.Enabled = false;
        }
    }
}
