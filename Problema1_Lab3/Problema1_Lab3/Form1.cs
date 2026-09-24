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

namespace Problema1_Lab3
{
    public partial class Form1 : Form
    {
        ArrayList listaPersonas = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona miColaborador = new Persona();
            miColaborador.Id = 1;
            miColaborador.Nombres = "Elena Carolina";
            miColaborador.Apellidos = "Gonzalez Rodríguez";
            miColaborador.Correo = "elena.gonzalez@ejemplo.com";
            miColaborador.FechaNacimiento = new DateTime(1990, 5, 15);
            
            listaPersonas.Add(miColaborador);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listaPersonas;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                errorProvider1.SetError(txtID, "Ingrese un ID");
                txtID.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtID, "");
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese los nombres del Colaborador");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                errorProvider1.SetError(txtApellido, "Ingrese los apellidos del Colaborador");
                txtApellido.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellido, "");
            }

            if (!Utilidades.EstaCorreoValido(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo válido");
                txtCorreo.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }

            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                errorProvider1.SetError(txtID, "Ingrese un ID numérico válido");
                txtID.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtID, "");
            }

            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido");
                txtSalario.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalario, "");
            }

            Persona colaborador = new Persona();
            colaborador.Id = id;
            colaborador.Nombres = txtNombre.Text;
            colaborador.Apellidos = txtApellido.Text;
            colaborador.Correo = txtCorreo.Text;
            colaborador.Salario = salario;
            colaborador.FechaNacimiento = dateTimePicker1.Value;

            listaPersonas.Add(colaborador);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listaPersonas;
        }
    }
}
