using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_problema1
{
    public partial class Form1 : Form
    {
        ArrayList ListaPersonas = new ArrayList();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona miColaborador1 = new Persona();

            miColaborador1.Id = 1;
            miColaborador1.Nombres = "Elena Carolina";
            miColaborador1.Apellidos = "Gonzalez Rodrígues";
            miColaborador1.Correo = "elena.gonzales@ejemplo.com";
            miColaborador1.FechaNacimiento = new DateTime(1990, 5, 15);
            ListaPersonas.Add(miColaborador1);
            dataGridView1.DataSource = ListaPersonas;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Ingrese un ID");

                    //.SetError(txtID, "Ingrese un ID");
                txtID.Focus();
                return;
                
            }
            else
            {
                errorProvider1.SetError(txtID, "");
            }

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese los nombres del colaborador");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            if (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtApellido, "Ingrese los apellidos del colaborador");
                txtApellido.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellido, "");
            }

            if (Utilidades.EsCorreoValido(txtEmail.Text) == false)
            {
                errorProvider1.SetError(txtEmail, "Ingrese un correo válido");
                txtEmail.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            decimal salario1;
            if (!decimal.TryParse(txtSalario.Text, out salario1))
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido");
                txtSalario.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(txtSalario, "");
            }


            Persona colaborador1 = new Persona();
            colaborador1.Id = int.Parse(txtID.Text);
            colaborador1.Nombres = txtNombre.Text;
            colaborador1.Apellidos = txtApellido.Text;
            colaborador1.Correo = txtEmail.Text;
            colaborador1.Salario = salario1;
            colaborador1.FechaNacimiento = DTPFecha.Value;
            ListaPersonas.Add(colaborador1);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaPersonas;
        }
    }
}
