
namespace T19_WindowsForms_Ejercicio3
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.gbSistemasOperativos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clbEspecialidad = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.btnFin = new System.Windows.Forms.Button();
            this.gbSistemasOperativos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija un sistema operativo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Windows";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Linux";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 19);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mac";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // gbSistemasOperativos
            // 
            this.gbSistemasOperativos.Controls.Add(this.radioButton1);
            this.gbSistemasOperativos.Controls.Add(this.radioButton3);
            this.gbSistemasOperativos.Controls.Add(this.radioButton2);
            this.gbSistemasOperativos.Location = new System.Drawing.Point(12, 60);
            this.gbSistemasOperativos.Name = "gbSistemasOperativos";
            this.gbSistemasOperativos.Size = new System.Drawing.Size(200, 100);
            this.gbSistemasOperativos.TabIndex = 4;
            this.gbSistemasOperativos.TabStop = false;
            this.gbSistemasOperativos.Text = "Sistemas Operativos:";
            this.gbSistemasOperativos.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elige tu especialidad:";
            // 
            // clbEspecialidad
            // 
            this.clbEspecialidad.FormattingEnabled = true;
            this.clbEspecialidad.Items.AddRange(new object[] {
            "Programación",
            "Diseño Gráfico",
            "Administración"});
            this.clbEspecialidad.Location = new System.Drawing.Point(12, 222);
            this.clbEspecialidad.Name = "clbEspecialidad";
            this.clbEspecialidad.Size = new System.Drawing.Size(120, 76);
            this.clbEspecialidad.TabIndex = 6;
            this.clbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horas dedicadas al ordenador:";
            // 
            // numHoras
            // 
            this.numHoras.Location = new System.Drawing.Point(342, 60);
            this.numHoras.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(120, 23);
            this.numHoras.TabIndex = 8;
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(342, 240);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(75, 23);
            this.btnFin.TabIndex = 9;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 365);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.numHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbEspecialidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbSistemasOperativos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSistemasOperativos.ResumeLayout(false);
            this.gbSistemasOperativos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox gbSistemasOperativos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbEspecialidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHoras;
        private System.Windows.Forms.Button btnFin;
    }
}

