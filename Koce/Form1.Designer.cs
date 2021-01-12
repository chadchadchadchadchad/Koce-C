namespace Koce
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.krajilistbox = new System.Windows.Forms.ListBox();
            this.kraj_text_kraj = new System.Windows.Forms.TextBox();
            this.posta_text_kraj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_kraj = new System.Windows.Forms.Button();
            this.delete_kraj = new System.Windows.Forms.Button();
            this.insert_kraj = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.kraj_combo = new System.Windows.Forms.ComboBox();
            this.gore_opis = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gorelistbox = new System.Windows.Forms.ListBox();
            this.gorevnesi = new System.Windows.Forms.Button();
            this.ime_text_gore = new System.Windows.Forms.TextBox();
            this.deletegore = new System.Windows.Forms.Button();
            this.updategore = new System.Windows.Forms.Button();
            this.jajaj = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // krajilistbox
            // 
            this.krajilistbox.FormattingEnabled = true;
            this.krajilistbox.ItemHeight = 16;
            this.krajilistbox.Location = new System.Drawing.Point(26, 25);
            this.krajilistbox.Name = "krajilistbox";
            this.krajilistbox.Size = new System.Drawing.Size(387, 484);
            this.krajilistbox.TabIndex = 2;
            this.krajilistbox.SelectedIndexChanged += new System.EventHandler(this.krajilistbox_SelectedIndexChanged);
            // 
            // kraj_text_kraj
            // 
            this.kraj_text_kraj.Location = new System.Drawing.Point(461, 86);
            this.kraj_text_kraj.Name = "kraj_text_kraj";
            this.kraj_text_kraj.Size = new System.Drawing.Size(279, 22);
            this.kraj_text_kraj.TabIndex = 3;
            // 
            // posta_text_kraj
            // 
            this.posta_text_kraj.Location = new System.Drawing.Point(461, 186);
            this.posta_text_kraj.Name = "posta_text_kraj";
            this.posta_text_kraj.Size = new System.Drawing.Size(279, 22);
            this.posta_text_kraj.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Posta";
            // 
            // update_kraj
            // 
            this.update_kraj.Enabled = false;
            this.update_kraj.Location = new System.Drawing.Point(551, 306);
            this.update_kraj.Name = "update_kraj";
            this.update_kraj.Size = new System.Drawing.Size(95, 23);
            this.update_kraj.TabIndex = 7;
            this.update_kraj.Text = "Posodobi";
            this.update_kraj.UseVisualStyleBackColor = true;
            this.update_kraj.Click += new System.EventHandler(this.update_Click);
            // 
            // delete_kraj
            // 
            this.delete_kraj.Enabled = false;
            this.delete_kraj.Location = new System.Drawing.Point(665, 306);
            this.delete_kraj.Name = "delete_kraj";
            this.delete_kraj.Size = new System.Drawing.Size(75, 23);
            this.delete_kraj.TabIndex = 8;
            this.delete_kraj.Text = "Zbriši";
            this.delete_kraj.UseVisualStyleBackColor = true;
            this.delete_kraj.Click += new System.EventHandler(this.delete_Click);
            // 
            // insert_kraj
            // 
            this.insert_kraj.Location = new System.Drawing.Point(461, 306);
            this.insert_kraj.Name = "insert_kraj";
            this.insert_kraj.Size = new System.Drawing.Size(75, 23);
            this.insert_kraj.TabIndex = 9;
            this.insert_kraj.Text = "Vnesi";
            this.insert_kraj.UseVisualStyleBackColor = true;
            this.insert_kraj.Click += new System.EventHandler(this.insert_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 622);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.krajilistbox);
            this.tabPage1.Controls.Add(this.insert_kraj);
            this.tabPage1.Controls.Add(this.kraj_text_kraj);
            this.tabPage1.Controls.Add(this.delete_kraj);
            this.tabPage1.Controls.Add(this.posta_text_kraj);
            this.tabPage1.Controls.Add(this.update_kraj);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 593);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kraji";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.kraj_combo);
            this.tabPage2.Controls.Add(this.gore_opis);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.gorelistbox);
            this.tabPage2.Controls.Add(this.gorevnesi);
            this.tabPage2.Controls.Add(this.ime_text_gore);
            this.tabPage2.Controls.Add(this.deletegore);
            this.tabPage2.Controls.Add(this.updategore);
            this.tabPage2.Controls.Add(this.jajaj);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 593);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gore";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kraj:";
            // 
            // kraj_combo
            // 
            this.kraj_combo.FormattingEnabled = true;
            this.kraj_combo.Location = new System.Drawing.Point(464, 445);
            this.kraj_combo.Name = "kraj_combo";
            this.kraj_combo.Size = new System.Drawing.Size(179, 24);
            this.kraj_combo.TabIndex = 19;
            // 
            // gore_opis
            // 
            this.gore_opis.Location = new System.Drawing.Point(464, 206);
            this.gore_opis.Name = "gore_opis";
            this.gore_opis.Size = new System.Drawing.Size(441, 175);
            this.gore_opis.TabIndex = 18;
            this.gore_opis.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ime";
            // 
            // gorelistbox
            // 
            this.gorelistbox.FormattingEnabled = true;
            this.gorelistbox.ItemHeight = 16;
            this.gorelistbox.Location = new System.Drawing.Point(29, 43);
            this.gorelistbox.Name = "gorelistbox";
            this.gorelistbox.Size = new System.Drawing.Size(387, 484);
            this.gorelistbox.TabIndex = 10;
            this.gorelistbox.SelectedIndexChanged += new System.EventHandler(this.gorelistbox_SelectedIndexChanged);
            // 
            // gorevnesi
            // 
            this.gorevnesi.Location = new System.Drawing.Point(436, 539);
            this.gorevnesi.Name = "gorevnesi";
            this.gorevnesi.Size = new System.Drawing.Size(75, 23);
            this.gorevnesi.TabIndex = 16;
            this.gorevnesi.Text = "Vnesi";
            this.gorevnesi.UseVisualStyleBackColor = true;
            // 
            // ime_text_gore
            // 
            this.ime_text_gore.Location = new System.Drawing.Point(464, 104);
            this.ime_text_gore.Name = "ime_text_gore";
            this.ime_text_gore.Size = new System.Drawing.Size(279, 22);
            this.ime_text_gore.TabIndex = 11;
            // 
            // deletegore
            // 
            this.deletegore.Enabled = false;
            this.deletegore.Location = new System.Drawing.Point(640, 539);
            this.deletegore.Name = "deletegore";
            this.deletegore.Size = new System.Drawing.Size(75, 23);
            this.deletegore.TabIndex = 15;
            this.deletegore.Text = "Zbriši";
            this.deletegore.UseVisualStyleBackColor = true;
            // 
            // updategore
            // 
            this.updategore.Enabled = false;
            this.updategore.Location = new System.Drawing.Point(526, 539);
            this.updategore.Name = "updategore";
            this.updategore.Size = new System.Drawing.Size(95, 23);
            this.updategore.TabIndex = 14;
            this.updategore.Text = "Posodobi";
            this.updategore.UseVisualStyleBackColor = true;
            this.updategore.Click += new System.EventHandler(this.updategore_Click);
            // 
            // jajaj
            // 
            this.jajaj.AutoSize = true;
            this.jajaj.Location = new System.Drawing.Point(464, 169);
            this.jajaj.Name = "jajaj";
            this.jajaj.Size = new System.Drawing.Size(37, 17);
            this.jajaj.TabIndex = 13;
            this.jajaj.Text = "Opis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 685);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Spreminjanje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox krajilistbox;
        private System.Windows.Forms.TextBox kraj_text_kraj;
        private System.Windows.Forms.TextBox posta_text_kraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_kraj;
        private System.Windows.Forms.Button delete_kraj;
        private System.Windows.Forms.Button insert_kraj;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kraj_combo;
        private System.Windows.Forms.RichTextBox gore_opis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox gorelistbox;
        private System.Windows.Forms.Button gorevnesi;
        private System.Windows.Forms.TextBox ime_text_gore;
        private System.Windows.Forms.Button updategore;
        private System.Windows.Forms.Label jajaj;
        private System.Windows.Forms.Button deletegore;
    }
}

