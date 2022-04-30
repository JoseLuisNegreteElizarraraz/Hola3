namespace Hola3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bienvenido = new System.Windows.Forms.Label();
            this.BtnCot = new System.Windows.Forms.Button();
            this.BtnReg = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bienvenido
            // 
            this.Bienvenido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bienvenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bienvenido.Font = new System.Drawing.Font("Sitka Heading", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
<<<<<<< HEAD
            this.Bienvenido.Location = new System.Drawing.Point(273, 111);
            this.Bienvenido.Name = "Bienvenido";
            this.Bienvenido.Size = new System.Drawing.Size(359, 101);
=======
            this.Bienvenido.Location = new System.Drawing.Point(416, 85);
            this.Bienvenido.Name = "Bienvenido";
            this.Bienvenido.Size = new System.Drawing.Size(367, 114);
>>>>>>> upstream/master
            this.Bienvenido.TabIndex = 0;
            this.Bienvenido.Text = "Bienvenido";
            this.Bienvenido.Click += new System.EventHandler(this.Bienvenido_Click);
            // 
            // BtnCot
            // 
            this.BtnCot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCot.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
<<<<<<< HEAD
            this.BtnCot.Location = new System.Drawing.Point(152, 276);
=======
            this.BtnCot.Location = new System.Drawing.Point(174, 337);
>>>>>>> upstream/master
            this.BtnCot.Name = "BtnCot";
            this.BtnCot.Size = new System.Drawing.Size(280, 130);
            this.BtnCot.TabIndex = 1;
            this.BtnCot.Text = "Cotizar";
            this.BtnCot.UseVisualStyleBackColor = true;
            this.BtnCot.Click += new System.EventHandler(this.BtnCot_Click);
            // 
            // BtnReg
            // 
            this.BtnReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReg.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
<<<<<<< HEAD
            this.BtnReg.Location = new System.Drawing.Point(348, 276);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(175, 97);
=======
            this.BtnReg.Location = new System.Drawing.Point(716, 337);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(295, 130);
>>>>>>> upstream/master
            this.BtnReg.TabIndex = 2;
            this.BtnReg.Text = "Empleado/Empresa";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(556, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 97);
            this.button3.TabIndex = 3;
            this.button3.Text = "Empleado/Empresa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(863, 487);
            this.Controls.Add(this.button3);
=======
            this.ClientSize = new System.Drawing.Size(1296, 708);
>>>>>>> upstream/master
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.BtnCot);
            this.Controls.Add(this.Bienvenido);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label Bienvenido;
        private Button BtnCot;
        private Button BtnReg;
        private Button button3;
    }
}