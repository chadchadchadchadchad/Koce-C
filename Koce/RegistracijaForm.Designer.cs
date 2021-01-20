
namespace Koce
{
    partial class RegistracijaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ime_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priimek_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.geslo_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tel_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // ime_text
            // 
            this.ime_text.Location = new System.Drawing.Point(59, 132);
            this.ime_text.Name = "ime_text";
            this.ime_text.Size = new System.Drawing.Size(172, 22);
            this.ime_text.TabIndex = 1;
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(59, 217);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(172, 22);
            this.email_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // priimek_text
            // 
            this.priimek_text.Location = new System.Drawing.Point(307, 132);
            this.priimek_text.Name = "priimek_text";
            this.priimek_text.Size = new System.Drawing.Size(172, 22);
            this.priimek_text.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Priimek:";
            // 
            // geslo_text
            // 
            this.geslo_text.Location = new System.Drawing.Point(307, 221);
            this.geslo_text.Name = "geslo_text";
            this.geslo_text.PasswordChar = '*';
            this.geslo_text.Size = new System.Drawing.Size(172, 22);
            this.geslo_text.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Geslo:";
            // 
            // tel_text
            // 
            this.tel_text.Location = new System.Drawing.Point(307, 305);
            this.tel_text.Name = "tel_text";
            this.tel_text.Size = new System.Drawing.Size(172, 22);
            this.tel_text.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 301);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kraj:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 44);
            this.label7.TabIndex = 12;
            this.label7.Text = "Registracija";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(59, 373);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(120, 23);
            this.register.TabIndex = 13;
            this.register.Text = "Registrirat";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // RegistracijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 445);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tel_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.geslo_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priimek_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ime_text);
            this.Controls.Add(this.label1);
            this.Name = "RegistracijaForm";
            this.Text = "RegistracijaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ime_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priimek_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox geslo_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button register;
    }
}