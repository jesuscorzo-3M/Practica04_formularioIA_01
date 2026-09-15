using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica04_formularioIA_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Grd_Click_1(object sender, EventArgs e)
        {
            // 1. Validación básica para evitar campos vacíos
            if (string.IsNullOrWhiteSpace(Txtb_Nom.Text) ||
                string.IsNullOrWhiteSpace(Txtb_Ape.Text) ||
                string.IsNullOrWhiteSpace(Txtb_Tel.Text) ||
                string.IsNullOrWhiteSpace(Txtb_Edad.Text) ||
                string.IsNullOrWhiteSpace(Txtb_Alt.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = Txtb_Nom.Text.Trim();
            string apellido = Txtb_Ape.Text.Trim();
            string telefono = Txtb_Tel.Text.Trim();
            string edad = Txtb_Edad.Text.Trim();
            string estatura = Txtb_Alt.Text.Trim();
            string genero = "No especificado";

            if (Rbtn_Mas.Checked)
            {
                genero = "Masculino";
            }
            else if (Rbtn_Fem.Checked)
            {
                genero = "Femenino";
            }
            else if (Rbtn_Otro.Checked)
            {
                genero = "Otro";
            }

            // Mensaje para mostrar en el MessageBox
            string mensaje = $"Nombres: {nombre}\nApellido: {apellido}\nGénero: {genero}\nEdad: {edad}\nTeléfono: {telefono}\nEstatura: {estatura}";

            try
            {
                // 2. Ruta dinámica (Se guarda en la carpeta Documentos del usuario actual de forma segura)
                string carpetaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string rutaFile = Path.Combine(carpetaDocumentos, "Actividad04IA_Vr_0001.txt");

                // 3. Escritura correcta de los datos en el archivo de texto
                using (StreamWriter escritor = new StreamWriter(rutaFile, true))
                {
                    escritor.WriteLine("--- Registro de Usuario ---");
                    escritor.WriteLine($"Nombre: {nombre} {apellido}");
                    escritor.WriteLine($"Género: {genero}");
                    escritor.WriteLine($"Edad: {edad}");
                    escritor.WriteLine($"Teléfono: {telefono}");
                    escritor.WriteLine($"Estatura: {estatura}");
                    escritor.WriteLine($"Fecha de registro: {DateTime.Now}");
                    escritor.WriteLine(new string('-', 30));
                }

                MessageBox.Show(mensaje + "\n\n¡Datos guardados exitosamente en Documentos!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Limpiar después de guardar con éxito
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Lpr_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            Txtb_Nom.Clear();
            Txtb_Ape.Clear();
            Txtb_Tel.Clear();
            Txtb_Edad.Clear();
            Txtb_Alt.Clear();

            Rbtn_Mas.Checked = false;
            Rbtn_Fem.Checked = false;
            Rbtn_Otro.Checked = false;

            Txtb_Nom.Focus(); // Devuelve el cursor al primer cuadro de texto
        }
    }
}
