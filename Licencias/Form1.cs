using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licencias
{
    public partial class Form1 : Form
    {
        clTransito tran = new clTransito();
        int val;
        List<clTransito> listaTransitosColombia = new List<clTransito>();
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            clTransito objetoTransito;           

            //1 elemento
            objetoTransito = new clTransito();
            objetoTransito.CodigoTransito = "001";
            objetoTransito.NombreCiudad = "Medellin";
            objetoTransito.CodigoCiudad = "01";
            objetoTransito.NombreTransito= "Caribe";
            listaTransitosColombia.Add(objetoTransito);

            objetoTransito = new clTransito();
            objetoTransito.CodigoTransito = "0001";
            objetoTransito.NombreCiudad = "Medellin";
            objetoTransito.CodigoCiudad = "01";
            objetoTransito.NombreTransito = "Municipal";
            listaTransitosColombia.Add(objetoTransito);

            objetoTransito = new clTransito();
            objetoTransito.CodigoTransito = "002";
            objetoTransito.NombreCiudad = "Bello";
            objetoTransito.CodigoCiudad = "02";
            objetoTransito.NombreTransito = "Bello";
            listaTransitosColombia.Add(objetoTransito);

            objetoTransito = new clTransito();
            objetoTransito.CodigoTransito = "003";
            objetoTransito.NombreCiudad = "Envigado";
            objetoTransito.CodigoCiudad = "03";
            objetoTransito.NombreTransito = "Envigado";
            listaTransitosColombia.Add(objetoTransito);

            objetoTransito = new clTransito();
            objetoTransito.CodigoTransito = "004";
            objetoTransito.NombreCiudad = "Itagui";
            objetoTransito.CodigoCiudad = "04";
            objetoTransito.NombreTransito = "Itagui";
            listaTransitosColombia.Add(objetoTransito);

            objetoTransito = new clTransito();
            objetoTransito.CodigoTransito = "005";
            objetoTransito.NombreCiudad = "Bogota";
            objetoTransito.CodigoCiudad = "05";
            objetoTransito.NombreTransito = "Bogota";
            listaTransitosColombia.Add(objetoTransito);

            objetoTransito = new clTransito();
            objetoTransito.CodigoTransito = "0005";
            objetoTransito.NombreCiudad = "Bogota";
            objetoTransito.CodigoCiudad = "05";
            objetoTransito.NombreTransito = "Cundinamarca";
            listaTransitosColombia.Add(objetoTransito);

            //Crear lista de ciudades y llenar combo ciudad
            clCiudad objetoCiudad;
            List<clCiudad>listaCiudades = new List<clCiudad>();

            objetoCiudad = new clCiudad();
            objetoCiudad.CodigoCiudad = "01";
            objetoCiudad.NombreCiudad = "Medellin";
            listaCiudades.Add(objetoCiudad);

            objetoCiudad = new clCiudad();
            objetoCiudad.CodigoCiudad = "02";
            objetoCiudad.NombreCiudad = "Bello";
            listaCiudades.Add(objetoCiudad);

            objetoCiudad = new clCiudad();
            objetoCiudad.CodigoCiudad = "03";
            objetoCiudad.NombreCiudad = "Envigado";
            listaCiudades.Add(objetoCiudad);

            objetoCiudad = new clCiudad();
            objetoCiudad.CodigoCiudad = "04";
            objetoCiudad.NombreCiudad = "Itagui";
            listaCiudades.Add(objetoCiudad);

            objetoCiudad = new clCiudad();
            objetoCiudad.CodigoCiudad = "05";
            objetoCiudad.NombreCiudad = "Bogota";
            listaCiudades.Add(objetoCiudad);

            //llenar combo
            cbCiudad.DataSource = listaCiudades;
            cbCiudad.DisplayMember = "NombreCiudad";
            cbCiudad.ValueMember = "CodigoCiudad";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string codigoCiudadSeleccionado = cbCiudad.SelectedValue.ToString();
            List<clTransito> lstTransitoCiudadFiltrada =
            listaTransitosColombia.Where(w=> w.CodigoCiudad == codigoCiudadSeleccionado).ToList();

            //llenar combo
            cbTransito.DataSource = null;
            cbTransito.DataSource = lstTransitoCiudadFiltrada;
            cbTransito.DisplayMember = "NombreTransito";
            cbTransito.ValueMember = "CodigoTransito";

            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int can = int.Parse(txtCantidad.Text);
            int tot = val * can;
            txtTotal.Text = tot.ToString();
            
        }

        private void cbTransito_SelectedIndexChanged(object sender, EventArgs e)
        {            
            tran.NombreTransito = cbTransito.Text;
            val = tran.ValorLicencia;            
            txtValor_licencia.Text = val.ToString();            
        }
    }
}
