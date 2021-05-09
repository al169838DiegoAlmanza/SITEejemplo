﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITE
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            //se cierra la ventana actual
            this.Hide();
            //se abre la pantalla 
            Historial historial = new Historial();
            historial.Show();
        }

        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            //se cierra la ventana actual
            this.Hide();
            //se abre la pantalla 
            Venta venta = new Venta();
            venta.Show();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            //se cierra la ventana actual
            this.Hide();
            //se abre la pantalla 
            Proveedor proveedor = new Proveedor();
            proveedor.Show();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            //se cierra la ventana actual
            this.Hide();
            //se abre la pantalla de historial
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //AQUI SE ENVIA AL MENU


            //se cierra la ventana actual
            //this.Hide();
            //se abre la pantalla de historial
            //Proveedor proveedor = new Proveedor();
            //proveedor.Show();
        }
    }
}
