using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_desconectada
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwind.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwind.Customers);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
            customersTableAdapter.Update(northwind.Customers);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            customersBindingSource.EndEdit();//Guardamos 
            MessageBox.Show("Customer guardado");
            customersTableAdapter.Update(northwind);//aplicamos los cambios y actualizamos el gridView
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            customersBindingSource.RemoveCurrent();
            MessageBox.Show("Customer eliminado");
            customersTableAdapter.Update(northwind);
        }
    }
}
