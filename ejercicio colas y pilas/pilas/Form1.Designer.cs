namespace pilas
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
            this.btn_despilar = new System.Windows.Forms.Button();
            this.btn_enpilar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_excel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_despilar
            // 
            this.btn_despilar.Location = new System.Drawing.Point(552, 357);
            this.btn_despilar.Name = "btn_despilar";
            this.btn_despilar.Size = new System.Drawing.Size(121, 23);
            this.btn_despilar.TabIndex = 11;
            this.btn_despilar.Text = "sacar de la pila";
            this.btn_despilar.UseVisualStyleBackColor = true;
            this.btn_despilar.Click += new System.EventHandler(this.btn_despilar_Click);
            // 
            // btn_enpilar
            // 
            this.btn_enpilar.Location = new System.Drawing.Point(155, 357);
            this.btn_enpilar.Name = "btn_enpilar";
            this.btn_enpilar.Size = new System.Drawing.Size(112, 23);
            this.btn_enpilar.TabIndex = 9;
            this.btn_enpilar.Text = "meter a la pila";
            this.btn_enpilar.UseVisualStyleBackColor = true;
            this.btn_enpilar.Click += new System.EventHandler(this.btn_enpilar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(101, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 228);
            this.listBox1.TabIndex = 8;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(130, 49);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombres";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(501, 100);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(206, 228);
            this.listBox2.TabIndex = 12;
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(339, 447);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(150, 39);
            this.btn_excel.TabIndex = 13;
            this.btn_excel.Text = "mostrar en excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_despilar);
            this.Controls.Add(this.btn_enpilar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_despilar;
        private System.Windows.Forms.Button btn_enpilar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_excel;
    }
}

