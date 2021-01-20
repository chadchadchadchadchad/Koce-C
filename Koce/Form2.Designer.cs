namespace Koce
{
    partial class koce_form
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
            this.searchtext = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kocelist = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dodaj_koco = new System.Windows.Forms.Button();
            this.vsi = new System.Windows.Forms.Button();
            this.prijava_but = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchtext
            // 
            this.searchtext.Location = new System.Drawing.Point(69, 111);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(473, 22);
            this.searchtext.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(571, 109);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Isci";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Koce";
            // 
            // kocelist
            // 
            this.kocelist.FormattingEnabled = true;
            this.kocelist.ItemHeight = 16;
            this.kocelist.Location = new System.Drawing.Point(69, 187);
            this.kocelist.Name = "kocelist";
            this.kocelist.Size = new System.Drawing.Size(608, 436);
            this.kocelist.TabIndex = 3;
            this.kocelist.SelectedIndexChanged += new System.EventHandler(this.kocelist_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Spremeni podatke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodaj_koco
            // 
            this.dodaj_koco.Location = new System.Drawing.Point(571, 647);
            this.dodaj_koco.Name = "dodaj_koco";
            this.dodaj_koco.Size = new System.Drawing.Size(106, 23);
            this.dodaj_koco.TabIndex = 5;
            this.dodaj_koco.Text = "Dodaj koco";
            this.dodaj_koco.UseVisualStyleBackColor = true;
            this.dodaj_koco.Click += new System.EventHandler(this.dodaj_koco_Click);
            // 
            // vsi
            // 
            this.vsi.Location = new System.Drawing.Point(69, 142);
            this.vsi.Name = "vsi";
            this.vsi.Size = new System.Drawing.Size(98, 23);
            this.vsi.TabIndex = 6;
            this.vsi.Text = "Izpisi vse";
            this.vsi.UseVisualStyleBackColor = true;
            this.vsi.Click += new System.EventHandler(this.vsi_Click);
            // 
            // prijava_but
            // 
            this.prijava_but.Location = new System.Drawing.Point(13, 13);
            this.prijava_but.Name = "prijava_but";
            this.prijava_but.Size = new System.Drawing.Size(75, 23);
            this.prijava_but.TabIndex = 7;
            this.prijava_but.Text = "Prijava";
            this.prijava_but.UseVisualStyleBackColor = true;
            this.prijava_but.Click += new System.EventHandler(this.prijava_but_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(94, 13);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(121, 23);
            this.user.TabIndex = 8;
            this.user.Text = "Uporabnik";
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // koce_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 698);
            this.Controls.Add(this.user);
            this.Controls.Add(this.prijava_but);
            this.Controls.Add(this.vsi);
            this.Controls.Add(this.dodaj_koco);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kocelist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchtext);
            this.Name = "koce_form";
            this.Text = "Koce";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox kocelist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dodaj_koco;
        private System.Windows.Forms.Button vsi;
        private System.Windows.Forms.Button prijava_but;
        private System.Windows.Forms.Button user;
    }
}