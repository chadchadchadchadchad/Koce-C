namespace Koce
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opis_text = new System.Windows.Forms.RichTextBox();
            this.ime_text = new System.Windows.Forms.TextBox();
            this.nadmorska_text = new System.Windows.Forms.TextBox();
            this.gora_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nadmorksa visina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gora:";
            // 
            // opis_text
            // 
            this.opis_text.Location = new System.Drawing.Point(74, 196);
            this.opis_text.Name = "opis_text";
            this.opis_text.Size = new System.Drawing.Size(486, 126);
            this.opis_text.TabIndex = 5;
            this.opis_text.Text = "";
            // 
            // ime_text
            // 
            this.ime_text.Location = new System.Drawing.Point(74, 101);
            this.ime_text.Name = "ime_text";
            this.ime_text.Size = new System.Drawing.Size(231, 22);
            this.ime_text.TabIndex = 6;
            // 
            // nadmorska_text
            // 
            this.nadmorska_text.Location = new System.Drawing.Point(74, 392);
            this.nadmorska_text.Name = "nadmorska_text";
            this.nadmorska_text.Size = new System.Drawing.Size(231, 22);
            this.nadmorska_text.TabIndex = 7;
            // 
            // gora_combo
            // 
            this.gora_combo.FormattingEnabled = true;
            this.gora_combo.Location = new System.Drawing.Point(74, 505);
            this.gora_combo.Name = "gora_combo";
            this.gora_combo.Size = new System.Drawing.Size(165, 24);
            this.gora_combo.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 608);
            this.Controls.Add(this.gora_combo);
            this.Controls.Add(this.nadmorska_text);
            this.Controls.Add(this.ime_text);
            this.Controls.Add(this.opis_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Spremeni koco";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox opis_text;
        private System.Windows.Forms.TextBox ime_text;
        private System.Windows.Forms.TextBox nadmorska_text;
        private System.Windows.Forms.ComboBox gora_combo;
    }
}