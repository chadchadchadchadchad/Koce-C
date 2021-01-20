
namespace Koce
{
    partial class PrijavaForm
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
            this.reg = new System.Windows.Forms.Button();
            this.geslo_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(285, 377);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(158, 23);
            this.reg.TabIndex = 0;
            this.reg.Text = "Registracija";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.button1_Click);
            // 
            // geslo_text
            // 
            this.geslo_text.Location = new System.Drawing.Point(69, 226);
            this.geslo_text.Name = "geslo_text";
            this.geslo_text.PasswordChar = '*';
            this.geslo_text.Size = new System.Drawing.Size(172, 22);
            this.geslo_text.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Geslo:";
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(69, 142);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(172, 22);
            this.email_text.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Prijava";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Se niste prijavljeni?";
            // 
            // prijava
            // 
            this.prijava.Location = new System.Drawing.Point(69, 318);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(75, 23);
            this.prijava.TabIndex = 14;
            this.prijava.Text = "Prijava";
            this.prijava.UseVisualStyleBackColor = true;
            this.prijava.Click += new System.EventHandler(this.prijava_Click);
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.prijava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geslo_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reg);
            this.Name = "PrijavaForm";
            this.Text = "PrijavaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.TextBox geslo_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button prijava;
    }
}