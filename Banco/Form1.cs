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

namespace Banco
{
    public partial class Form1 : Form
    {
        ArrayList listaCuentas;

        private void inicializarCuentasBase()
        {
            Cuenta cuenta1 = new Cuenta("11111111", "Alejandro Elvira", 10000, 1.2);
            Cuenta cuenta2 = new Cuenta("22222222", "Rodrigo Corrales", 500, 1.2);
            CuentaAhorro cuenta3 = new CuentaAhorro("33333333", "Francisco Reyes", 3000, 2.1, 20);
            CuentaAhorro cuenta4 = new CuentaAhorro("44444444", "Guillermo Osuna", 20000, 2.1, 10);

            this.listaCuentas = new ArrayList();
            listaCuentas.Add(cuenta1);
            listaCuentas.Add(cuenta2);
            listaCuentas.Add(cuenta3);
            listaCuentas.Add(cuenta4);

            comboBoxCuentas.Items.Clear();
            comboBoxCuentas.Items.AddRange(this.listaCuentas.ToArray());
        }
        public Form1()
        {
            InitializeComponent();
            inicializarCuentasBase();
        }

        private void comboBoxCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarTextBoxes();

            Cuenta cuentaSeleccionada = (Cuenta)listaCuentas[comboBoxCuentas.SelectedIndex];

            textBoxNumeroCuenta.Text = cuentaSeleccionada.NumCuenta;
            textBoxTitularCuenta.Text = cuentaSeleccionada.Nombre;
            textBoxSaldoCuenta.Text = Convert.ToString(cuentaSeleccionada.Saldo);
            textBoxInteresCuenta.Text = Convert.ToString(cuentaSeleccionada.TipoInteres);

            if (cuentaSeleccionada is CuentaAhorro)
                textBoxCuotaCuenta.Text = Convert.ToString(((CuentaAhorro)cuentaSeleccionada).CuotaMantenimiento);
        }

        private void limpiarTextBoxes()
        {
            textBoxNumeroCuenta.Text = "";
            textBoxTitularCuenta.Text = "";
            textBoxSaldoCuenta.Text = "";
            textBoxInteresCuenta.Text = "";
            textBoxCuotaCuenta.Text = "";
        }

        private void habilitarTextBoxes()
        {
            textBoxNumeroCuenta.Enabled = true;
            textBoxTitularCuenta.Enabled = true;
            textBoxSaldoCuenta.Enabled = true;
            textBoxInteresCuenta.Enabled = true;
            textBoxCuotaCuenta.Enabled = true;
        }

        private void deshabilitarTextBoxes()
        {
            textBoxNumeroCuenta.Enabled = false;
            textBoxTitularCuenta.Enabled = false;
            textBoxSaldoCuenta.Enabled = false;
            textBoxInteresCuenta.Enabled = false;
            textBoxCuotaCuenta.Enabled = false;
        }
        private void botonAniadir_Click(object sender, EventArgs e)
        {
            comboBoxCuentas.Visible = false;
            botonAniadir.Visible = false;
            botonGuardar.Visible = true;

            habilitarTextBoxes();
            limpiarTextBoxes();
        }

        private bool comprobarSiHayCamposVacios()
        {
            if (textBoxNumeroCuenta.Text == "") return true;
            if (textBoxTitularCuenta.Text == "") return true;
            if (textBoxSaldoCuenta.Text == "") return true;
            if (textBoxInteresCuenta.Text == "") return true;

            return false;
        }

        private Cuenta generarCuenta()
        {
            if (textBoxCuotaCuenta.Text != "")
                return new CuentaAhorro();
            else
                return new Cuenta();
        }

        private bool verSiCadenaEsDouble(String cadena)
        {
            try
            {
                Convert.ToDouble(cadena);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        private void botonGuardar_Click(object sender, EventArgs e)
        {

            if (comprobarSiHayCamposVacios())
            {
                MessageBox.Show("Hay campos sin rellenar (La cuota de mantenimiento es opcional)","Error");
                return;
            }

            if (!verSiCadenaEsDouble(textBoxSaldoCuenta.Text))
            {
                MessageBox.Show("Ha introducido algo que no es un número en el campo 'Saldo'","Error");
                return;
            }

            if (!verSiCadenaEsDouble(textBoxInteresCuenta.Text))
            {
                MessageBox.Show("Ha introducido algo que no es un número en el campo 'Interés'","Error");
                return;
            }

            if (!verSiCadenaEsDouble(textBoxInteresCuenta.Text))
            {
                MessageBox.Show("Ha introducido algo que no es un número en el campo 'Cuota mantenimiento'","Error");
                return;
            }

            Cuenta nuevaCuenta = generarCuenta();

            nuevaCuenta.NumCuenta = textBoxNumeroCuenta.Text;
            nuevaCuenta.Nombre = textBoxTitularCuenta.Text;
            nuevaCuenta.Saldo = Convert.ToDouble(textBoxSaldoCuenta.Text);
            nuevaCuenta.TipoInteres = Convert.ToDouble(textBoxInteresCuenta.Text);
            if (nuevaCuenta is CuentaAhorro) ((CuentaAhorro)nuevaCuenta).CuotaMantenimiento = Convert.ToDouble(textBoxCuotaCuenta.Text);
            
            listaCuentas.Add(nuevaCuenta);
            comboBoxCuentas.Items.Add(nuevaCuenta);

            comboBoxCuentas.Visible = true;
            botonAniadir.Visible = true;
            botonGuardar.Visible = false;

            deshabilitarTextBoxes();
            limpiarTextBoxes();
            MessageBox.Show("Cuenta creada con éxito", "Éxito");
        }
    }
}
