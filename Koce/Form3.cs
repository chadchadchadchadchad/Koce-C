﻿using Npgsql;
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
    public partial class kocapage : Form
    {
        string ime_k = "";
        koca takoca = new koca();

        public kocapage(koca a)
        {
            InitializeComponent();

            ime_k = a.ime;
            takoca = a;
        }

        private void kocapage_Load(object sender, EventArgs e)
        {
            label1.Text = ime_k;

            using (NpgsqlConnection con = new NpgsqlConnection("Server=rogue.db.elephantsql.com; User Id=clhpojwc;" + "Password=wm7N_asXtodPaLSASbaFBEAcB1MtcKMU; Database=clhpojwc;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM vrnikoco('"+ ime_k +"')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text = reader.GetString(0);
                    richTextBox1.Text = reader.GetString(1);

                    string nadmorska = "Nadmorska visina: " + reader.GetInt32(2) + "m";
                    string gora = "Gora: " + reader.GetString(3);
                    listBox1.Items.Add(nadmorska);
                    listBox1.Items.Add(gora);

                }
                con.Close();
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            Form4 spremenikoco = new Form4(takoca);

            spremenikoco.Show();

            this.Hide();
        }
    }
}