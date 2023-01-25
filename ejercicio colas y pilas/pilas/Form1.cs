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

namespace pilas
{
    public partial class Form1 : Form
    {
        Stack<string> nombres = new Stack<string>();
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enpilar_Click(object sender, EventArgs e)
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
                    nombres.Push(dato);
                    listBox1.Items.Add(nombres.ElementAt(x));
                    //MessageBox.Show("El tamaño de la pila es :  " + nombres.Count(), "Mensaje");

                    txt_nombre.Clear();
                    txt_nombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo ocurrio" + ex);
            }
        }

        private void btn_despilar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombres.Count() > 0)
                {
                    listBox2.Items.Add(nombres.Pop());
                    //MessageBox.Show("El tamaño de la pila es :  " + nombres.Count(), "Mensaje");
                }
                if (nombres.Count() < 0)
                {
                    MessageBox.Show("ya no existen mas elmentos para sacar de la pila");
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
            Hoja.Cells[1, "B"] = "APILAR";
            Hoja.Cells[1, "C"] = "DESEMPILAR";

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
    }
}
