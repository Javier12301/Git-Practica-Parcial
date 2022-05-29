namespace Practica_Parcial
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNumerador = new System.Windows.Forms.Label();
            this.lblDenominador = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(59, 115);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(137, 52);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Cálcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 23);
            this.textBox2.TabIndex = 1;
            // 
            // lblNumerador
            // 
            this.lblNumerador.AutoSize = true;
            this.lblNumerador.Location = new System.Drawing.Point(38, 29);
            this.lblNumerador.Name = "lblNumerador";
            this.lblNumerador.Size = new System.Drawing.Size(68, 15);
            this.lblNumerador.TabIndex = 2;
            this.lblNumerador.Text = "Numerador";
            // 
            // lblDenominador
            // 
            this.lblDenominador.AutoSize = true;
            this.lblDenominador.Location = new System.Drawing.Point(150, 29);
            this.lblDenominador.Name = "lblDenominador";
            this.lblDenominador.Size = new System.Drawing.Size(80, 15);
            this.lblDenominador.TabIndex = 2;
            this.lblDenominador.Text = "Denominador";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 179);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblDenominador);
            this.Controls.Add(this.lblNumerador);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblNumerador;
        private Label lblDenominador;
        private CheckBox checkBox1;
    }
}