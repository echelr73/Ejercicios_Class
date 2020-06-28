namespace Ejercicio_Class
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
            this.tbBase = new System.Windows.Forms.TextBox();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCrear = new System.Windows.Forms.Button();
            this.lbRectangulo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.lbPerimetro = new System.Windows.Forms.ListBox();
            this.bArea = new System.Windows.Forms.Button();
            this.bPerimetro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBase
            // 
            this.tbBase.Location = new System.Drawing.Point(90, 25);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(100, 20);
            this.tbBase.TabIndex = 0;
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(90, 61);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(100, 20);
            this.tbAltura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura:";
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(221, 41);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(75, 23);
            this.bCrear.TabIndex = 2;
            this.bCrear.Text = "Crear";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // lbRectangulo
            // 
            this.lbRectangulo.FormattingEnabled = true;
            this.lbRectangulo.Location = new System.Drawing.Point(53, 111);
            this.lbRectangulo.Name = "lbRectangulo";
            this.lbRectangulo.Size = new System.Drawing.Size(148, 147);
            this.lbRectangulo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.Location = new System.Drawing.Point(543, 111);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(226, 30);
            this.lbArea.TabIndex = 5;
            // 
            // lbPerimetro
            // 
            this.lbPerimetro.FormattingEnabled = true;
            this.lbPerimetro.Location = new System.Drawing.Point(543, 228);
            this.lbPerimetro.Name = "lbPerimetro";
            this.lbPerimetro.Size = new System.Drawing.Size(226, 30);
            this.lbPerimetro.TabIndex = 5;
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(426, 118);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(75, 23);
            this.bArea.TabIndex = 6;
            this.bArea.Text = "Area";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // bPerimetro
            // 
            this.bPerimetro.Location = new System.Drawing.Point(426, 235);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(75, 23);
            this.bPerimetro.TabIndex = 7;
            this.bPerimetro.Text = "Perimetro";
            this.bPerimetro.UseVisualStyleBackColor = true;
            this.bPerimetro.Click += new System.EventHandler(this.bPerimetro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bPerimetro);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.lbPerimetro);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRectangulo);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.tbBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.ListBox lbRectangulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.ListBox lbPerimetro;
        private System.Windows.Forms.Button bArea;
        private System.Windows.Forms.Button bPerimetro;
    }
}

