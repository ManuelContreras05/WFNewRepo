namespace WFrectangulo
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
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnDibujo = new System.Windows.Forms.Button();
            this.lblRectangulo = new System.Windows.Forms.Label();
            this.txtConteo = new System.Windows.Forms.TextBox();
            this.lblX2 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lblY2 = new System.Windows.Forms.Label();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(23, 31);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(41, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "XInicial";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(70, 28);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 1;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(183, 31);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(41, 13);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "YInicial";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(230, 28);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 3;
            // 
            // btnDibujo
            // 
            this.btnDibujo.Location = new System.Drawing.Point(94, 149);
            this.btnDibujo.Name = "btnDibujo";
            this.btnDibujo.Size = new System.Drawing.Size(150, 23);
            this.btnDibujo.TabIndex = 4;
            this.btnDibujo.Text = "Dibujar linea";
            this.btnDibujo.UseVisualStyleBackColor = true;
            this.btnDibujo.Click += new System.EventHandler(this.btnDibujo_Click);
            // 
            // lblRectangulo
            // 
            this.lblRectangulo.AutoSize = true;
            this.lblRectangulo.Location = new System.Drawing.Point(580, 260);
            this.lblRectangulo.Name = "lblRectangulo";
            this.lblRectangulo.Size = new System.Drawing.Size(107, 13);
            this.lblRectangulo.TabIndex = 5;
            this.lblRectangulo.Text = "Cantidad rectangulos";
            // 
            // txtConteo
            // 
            this.txtConteo.Location = new System.Drawing.Point(543, 276);
            this.txtConteo.Name = "txtConteo";
            this.txtConteo.Size = new System.Drawing.Size(170, 20);
            this.txtConteo.TabIndex = 6;
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(23, 73);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(36, 13);
            this.lblX2.TabIndex = 7;
            this.lblX2.Text = "XFinal";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(70, 73);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 20);
            this.txtX2.TabIndex = 8;
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(183, 73);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(36, 13);
            this.lblY2.TabIndex = 9;
            this.lblY2.Text = "YFinal";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(230, 73);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 20);
            this.txtY2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(97, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 142);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.lblY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.txtConteo);
            this.Controls.Add(this.lblRectangulo);
            this.Controls.Add(this.btnDibujo);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnDibujo;
        private System.Windows.Forms.Label lblRectangulo;
        private System.Windows.Forms.TextBox txtConteo;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

