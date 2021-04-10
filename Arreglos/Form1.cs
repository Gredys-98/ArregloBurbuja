using Arreglos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {
        private string[] arregloNotas;

        public Form1()
        {
            InitializeComponent();
        }
        private void Cargar_Click(object sender, EventArgs e)
        {

            ClsArchivo1 ar = new ClsArchivo1();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "seleciona tu archivo plano porfavor";
            ofd.InitialDirectory = @"C:\Users\Gredy\Desktop\archivo plano";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.leerTodoArchivo(archivo);
                arregloNotas = ar.LeerArchivo(archivo);
                textBox1.Text = resultado;
            }
        }
        private void Promedio1_Click(object sender, EventArgs e)
        {
            int par1;
            int part2;
            int part3;
            int suma;
            int contador = 1;
            foreach (string linea in arregloNotas)
            {
                if (contador > 1)
                {
                    string[] primernota = linea.Split(';');
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    par1 = Convert.ToInt32(primernota[2]);
                    part2 = Convert.ToInt32(primernota[2]);
                    part3 = Convert.ToInt32(primernota[2]);
                    suma = (par1 + part2 + part3) /3;
                    listBoxPromedio1.Items.Add($"{primernota[1]});Promedio{suma}");

                }
                contador++;
            }
        }
        private void button1prom2_Click(object sender, EventArgs e)
        {
            int par1;
            int part2;
            int part3;
            int suma;
            int contador = 1;
            foreach (string linea in arregloNotas)
            {
                if (contador > 1)
                {
                    string[] segundanota = linea.Split(';');
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    par1 = Convert.ToInt32(segundanota[3]);
                    part2 = Convert.ToInt32(segundanota[3]);
                    part3 = Convert.ToInt32(segundanota[3]);
                    suma = (par1 + part2 + part3) / 3;
                    listBoxPromedio1.Items.Add($"{segundanota[1]});Promedio{suma}");
                }
                contador++;
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            listBoxPromedio1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int par1;
            int part2;
            int part3;
            int suma;
            int contador = 1;
            foreach (string linea in arregloNotas)
            {
                if (contador > 1)
                {
                    string[] terceranota = linea.Split(';');
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    par1 = Convert.ToInt32(terceranota[4]);
                    part2 = Convert.ToInt32(terceranota[4]);
                    part3 = Convert.ToInt32(terceranota[4]);
                    suma = (par1 + part2 + part3) / 3;
                    
                    listBoxPromedio1.Items.Add($"{terceranota[1]});Promedio{suma}");
                }
                contador++;
            }
        }

        private void button2promGeneral_Click(object sender, EventArgs e)
        {
            {
                int par1;
                int part2;
                int part3;
                int suma;
                int contador = 1;
                foreach (string linea in arregloNotas)
                {
                    if (contador > 1)
                    {
                        string[] total = linea.Split(';');
                        Console.OutputEncoding = System.Text.Encoding.Unicode;
                        par1 = Convert.ToInt32(total[2]);                      
                        part2 = Convert.ToInt32(total[3]);
                        part3 = Convert.ToInt32(total[4]);                       
                        suma = (par1 + part2 + part3) / 3;
                        listBoxPromedio1.Items.Add($"{total[1]});Promedio{suma}");
                    }
                    contador++;                   
                }
            }
        }

        private void button2mayornota_Click(object sender, EventArgs e)
        {
        }

        private void nombre_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (string linea in arregloNotas)
            {
                if (contador > 0)
                {
                    string[] datos = linea.Split(';');
                    listBoxPromedio1.Items.Add(datos[1]);
                }

                contador++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
        } 
    }
}
