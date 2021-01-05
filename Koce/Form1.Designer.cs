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
            this.kraj_text = new System.Windows.Forms.TextBox();
            this.posta_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // krajilistbox
            // 
            this.krajilistbox.FormattingEnabled = true;
            this.krajilistbox.ItemHeight = 16;
            this.krajilistbox.Location = new System.Drawing.Point(27, 44);
            this.krajilistbox.Name = "krajilistbox";
            this.krajilistbox.Size = new System.Drawing.Size(355, 372);
            this.krajilistbox.TabIndex = 2;
            this.krajilistbox.SelectedIndexChanged += new System.EventHandler(this.krajilistbox_SelectedIndexChanged);
            // 
            // kraj_text
            // 
            this.kraj_text.Location = new System.Drawing.Point(420, 82);
            this.kraj_text.Name = "kraj_text";
            this.kraj_text.Size = new System.Drawing.Size(279, 22);
            this.kraj_text.TabIndex = 3;
            // 
            // posta_text
            // 
            this.posta_text.Location = new System.Drawing.Point(420, 182);
            this.posta_text.Name = "posta_text";
            this.posta_text.Size = new System.Drawing.Size(279, 22);
            this.posta_text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Posta";
            // 
            // update
            // 
            this.update.Enabled = false;
            this.update.Location = new System.Drawing.Point(510, 302);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(95, 23);
            this.update.TabIndex = 7;
            this.update.Text = "Posodobi";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(624, 302);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 8;
            this.delete.Text = "Zbriši";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(420, 302);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 9;
            this.insert.Text = "Vnesi";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 498);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posta_text);
            this.Controls.Add(this.kraj_text);
            this.Controls.Add(this.krajilistbox);
            this.Name = "Form1";
            this.Text = "Kraji";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox krajilistbox;
        private System.Windows.Forms.TextBox kraj_text;
        private System.Windows.Forms.TextBox posta_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button insert;
    }
}

