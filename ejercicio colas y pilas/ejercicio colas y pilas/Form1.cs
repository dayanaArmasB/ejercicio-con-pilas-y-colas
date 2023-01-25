using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ejercicio_colas_y_pilas
{
    public partial class Form1 : Form
    {
        Queue<string> nombres = new Queue<string>();
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_encolar_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = txt_nombre.Text;

                if (dato.Length == 0)
                {
                    MessageBox.Show("por favor ingrese el dato requerido");
                    txt_nombre.Focus();
                }
                else
                {

                    nombres.Enqueue(dato);
                    listBox1.Items.Add(nombres.ElementAt(x));
                    x++;
                    //MessageBox.Show("El tamaño de la cola es :  " + nombres.Count(), "Mensaje");

                    txt_nombre.Clear();
                    txt_nombre.Focus();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("algo ocurrio" + ex);
            }

        }

        private void btn_desencolar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombres.Count() > 0)
                {
                    listBox2.Items.Add(nombres.Dequeue());
                    //MessageBox.Show("El tamaño de la cola es :  " + nombres.Count(), "Mensaje");
                }
                if (nombres.Count() < 0)
                {
                    MessageBox.Show("ya no existen mas elmentos para sacar de la cola");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("algo ocurrio" + ex);
            }

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {

            var excelApp = new Excel.Application();

            excelApp.Visible = true;
            excelApp.Workbooks.Add();

            Excel._Worksheet Hoja = (Excel.Worksheet)excelApp.ActiveSheet;
            Hoja.Cells[1, "A"] = "#";
            Hoja.Cells[1, "B"] = "ENCOLAR";
            Hoja.Cells[1, "C"] = "DESENCOLAR";
            
            var fila = 1;
            for (int n = 0; n < listBox1.Items.Count; n++)
            {
                fila++;
                Hoja.Cells[fila, "A"] = n + 1;
            }


            foreach (var item in listBox1.Items)
            {
                fila++;
                Hoja.Cells[fila, "B"] = item;
                Hoja.Columns[2].Autofit();
            }

            foreach (var item2 in listBox2.Items)
            {
                fila++;
                Hoja.Cells[fila, "C"] = item2;
                Hoja.Columns[3].Autofit();
            }


        }

        private void btn_hilo_Click(object sender, EventArgs e)
        {

        }
    }
}
