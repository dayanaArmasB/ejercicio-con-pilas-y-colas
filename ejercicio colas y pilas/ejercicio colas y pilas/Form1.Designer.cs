namespace ejercicio_colas_y_pilas
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_encolar = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_desencolar = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_hilo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(104, 49);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(75, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 228);
            this.listBox1.TabIndex = 2;
            // 
            // btn_encolar
            // 
            this.btn_encolar.Location = new System.Drawing.Point(144, 357);
            this.btn_encolar.Name = "btn_encolar";
            this.btn_encolar.Size = new System.Drawing.Size(75, 23);
            this.btn_encolar.TabIndex = 3;
            this.btn_encolar.Text = "encolar";
            this.btn_encolar.UseVisualStyleBackColor = true;
            this.btn_encolar.Click += new System.EventHandler(this.btn_encolar_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(320, 100);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(206, 228);
            this.listBox2.TabIndex = 4;
            // 
            // btn_desencolar
            // 
            this.btn_desencolar.Location = new System.Drawing.Point(387, 357);
            this.btn_desencolar.Name = "btn_desencolar";
            this.btn_desencolar.Size = new System.Drawing.Size(97, 23);
            this.btn_desencolar.TabIndex = 5;
            this.btn_desencolar.Text = "desencolar";
            this.btn_desencolar.UseVisualStyleBackColor = true;
            this.btn_desencolar.Click += new System.EventHandler(this.btn_desencolar_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(131, 408);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(150, 39);
            this.btn_excel.TabIndex = 14;
            this.btn_excel.Text = "mostrar en excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_hilo
            // 
            this.btn_hilo.Location = new System.Drawing.Point(320, 410);
            this.btn_hilo.Name = "btn_hilo";
            this.btn_hilo.Size = new System.Drawing.Size(131, 37);
            this.btn_hilo.TabIndex = 15;
            this.btn_hilo.Text = "usar hilo";
            this.btn_hilo.UseVisualStyleBackColor = true;
            this.btn_hilo.Click += new System.EventHandler(this.btn_hilo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 502);
            this.Controls.Add(this.btn_hilo);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_desencolar);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_encolar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_encolar;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_desencolar;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_hilo;
    }
}

