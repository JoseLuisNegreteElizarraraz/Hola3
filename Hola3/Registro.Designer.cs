namespace Hola3
{
    partial class Registro
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
            this.BtnBak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBak
            // 
            this.BtnBak.Location = new System.Drawing.Point(333, 212);
            this.BtnBak.Name = "BtnBak";
            this.BtnBak.Size = new System.Drawing.Size(75, 23);
            this.BtnBak.TabIndex = 0;
            this.BtnBak.Text = "Inicio";
            this.BtnBak.UseVisualStyleBackColor = true;
            this.BtnBak.Click += new System.EventHandler(this.BtnBak_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBak);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnBak;
    }
}