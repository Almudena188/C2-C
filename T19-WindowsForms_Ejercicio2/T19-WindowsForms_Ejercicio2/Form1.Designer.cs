
namespace T19_WindowsForms_Ejercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPeliculas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribe el titulo de una pelicula";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(128, 202);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peliculas";
            // 
            // cbPeliculas
            // 
            this.cbPeliculas.FormattingEnabled = true;
            this.cbPeliculas.Location = new System.Drawing.Point(497, 146);
            this.cbPeliculas.Name = "cbPeliculas";
            this.cbPeliculas.Size = new System.Drawing.Size(121, 23);
            this.cbPeliculas.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbPeliculas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPeliculas;
    }
}

