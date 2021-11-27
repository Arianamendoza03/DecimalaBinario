
namespace DecimalaBinario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk8 = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBinaDec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Entero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(227, 46);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(86, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk8);
            this.groupBox1.Controls.Add(this.chk7);
            this.groupBox1.Controls.Add(this.chk6);
            this.groupBox1.Controls.Add(this.chk5);
            this.groupBox1.Controls.Add(this.chk4);
            this.groupBox1.Controls.Add(this.chk3);
            this.groupBox1.Controls.Add(this.chk2);
            this.groupBox1.Controls.Add(this.chk1);
            this.groupBox1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equivalente en Binario";
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(637, 67);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(15, 14);
            this.chk1.TabIndex = 0;
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(544, 67);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(15, 14);
            this.chk2.TabIndex = 1;
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(453, 67);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(15, 14);
            this.chk3.TabIndex = 2;
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(353, 67);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(15, 14);
            this.chk4.TabIndex = 3;
            this.chk4.UseVisualStyleBackColor = true;
            this.chk4.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(273, 67);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(15, 14);
            this.chk5.TabIndex = 4;
            this.chk5.UseVisualStyleBackColor = true;
            this.chk5.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(193, 67);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(15, 14);
            this.chk6.TabIndex = 5;
            this.chk6.UseVisualStyleBackColor = true;
            this.chk6.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(98, 67);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(15, 14);
            this.chk7.TabIndex = 6;
            this.chk7.UseVisualStyleBackColor = true;
            this.chk7.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // chk8
            // 
            this.chk8.AutoSize = true;
            this.chk8.Location = new System.Drawing.Point(34, 67);
            this.chk8.Name = "chk8";
            this.chk8.Size = new System.Drawing.Size(15, 14);
            this.chk8.TabIndex = 7;
            this.chk8.UseVisualStyleBackColor = true;
            this.chk8.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(86, 270);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(174, 71);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular ";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBinaDec
            // 
            this.btnBinaDec.Location = new System.Drawing.Point(473, 283);
            this.btnBinaDec.Name = "btnBinaDec";
            this.btnBinaDec.Size = new System.Drawing.Size(142, 57);
            this.btnBinaDec.TabIndex = 4;
            this.btnBinaDec.Text = "Convertir binario a decimal";
            this.btnBinaDec.UseVisualStyleBackColor = true;
            this.btnBinaDec.Click += new System.EventHandler(this.btnBinaDec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBinaDec);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Convierta un entero en Binario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk8;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBinaDec;
    }
}

