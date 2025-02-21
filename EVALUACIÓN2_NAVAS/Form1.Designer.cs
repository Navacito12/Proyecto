namespace EVALUACIÓN2_NAVAS
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeo1 = new System.Windows.Forms.TextBox();
            this.txtTeo2 = new System.Windows.Forms.TextBox();
            this.txtTeo3 = new System.Windows.Forms.TextBox();
            this.txtLab1 = new System.Windows.Forms.TextBox();
            this.txtLab2 = new System.Windows.Forms.TextBox();
            this.txtLab3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORMATICA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEORIA ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "LABORATORIO";
            // 
            // txtTeo1
            // 
            this.txtTeo1.Location = new System.Drawing.Point(199, 114);
            this.txtTeo1.Multiline = true;
            this.txtTeo1.Name = "txtTeo1";
            this.txtTeo1.Size = new System.Drawing.Size(108, 27);
            this.txtTeo1.TabIndex = 3;
            // 
            // txtTeo2
            // 
            this.txtTeo2.Location = new System.Drawing.Point(199, 174);
            this.txtTeo2.Multiline = true;
            this.txtTeo2.Name = "txtTeo2";
            this.txtTeo2.Size = new System.Drawing.Size(108, 27);
            this.txtTeo2.TabIndex = 4;
            // 
            // txtTeo3
            // 
            this.txtTeo3.Location = new System.Drawing.Point(199, 239);
            this.txtTeo3.Multiline = true;
            this.txtTeo3.Name = "txtTeo3";
            this.txtTeo3.Size = new System.Drawing.Size(108, 27);
            this.txtTeo3.TabIndex = 5;
            // 
            // txtLab1
            // 
            this.txtLab1.Location = new System.Drawing.Point(546, 114);
            this.txtLab1.Multiline = true;
            this.txtLab1.Name = "txtLab1";
            this.txtLab1.Size = new System.Drawing.Size(108, 27);
            this.txtLab1.TabIndex = 6;
            // 
            // txtLab2
            // 
            this.txtLab2.Location = new System.Drawing.Point(546, 174);
            this.txtLab2.Multiline = true;
            this.txtLab2.Name = "txtLab2";
            this.txtLab2.Size = new System.Drawing.Size(108, 27);
            this.txtLab2.TabIndex = 7;
            // 
            // txtLab3
            // 
            this.txtLab3.Location = new System.Drawing.Point(546, 239);
            this.txtLab3.Multiline = true;
            this.txtLab3.Name = "txtLab3";
            this.txtLab3.Size = new System.Drawing.Size(108, 27);
            this.txtLab3.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(359, 295);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 38);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular el promedio ";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(377, 359);
            this.lblResultado.Multiline = true;
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(113, 33);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLab3);
            this.Controls.Add(this.txtLab2);
            this.Controls.Add(this.txtLab1);
            this.Controls.Add(this.txtTeo3);
            this.Controls.Add(this.txtTeo2);
            this.Controls.Add(this.txtTeo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeo1;
        private System.Windows.Forms.TextBox txtTeo2;
        private System.Windows.Forms.TextBox txtTeo3;
        private System.Windows.Forms.TextBox txtLab1;
        private System.Windows.Forms.TextBox txtLab2;
        private System.Windows.Forms.TextBox txtLab3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox lblResultado;
    }
}

