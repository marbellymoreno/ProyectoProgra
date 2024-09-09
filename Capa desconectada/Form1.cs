using AccesoDatos;
using Capa_desconectada.NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_desconectada
{
    public partial class Form1 : Form
    {
        #region No Tipado 
        private CustomerRepository customerRepository = new CustomerRepository();
        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            gridNotipado.DataSource = customerRepository.ObtenerTodos();
        }
        private void btnBuscarNt_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.obtenerPorID(tbBusquedaNt.Text);
            if (cliente == null)
            {
                MessageBox.Show("El objeto es null");
            }
            if (cliente != null)
            {
                var listaClientes = new List<Customer> { cliente };
                gridNotipado.DataSource = listaClientes;
            }
        }
        #endregion

        #region Tipado 
        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        private void btnObtenerTipado_Click(object sender, EventArgs e)
        {
            var customers = adaptador.GetData();
            gridTipado.DataSource = customers;
        }

        private void btnBuscarTipado_Click(object sender, EventArgs e)
        {
            var customerData = adaptador.GetDataByCustomerID(tboxBuscarTipado.Text);

            if (customerData != null && customerData.Rows.Count > 0)
            {
                // Extraer el primer cliente de la tabla (suponiendo que es único)
                var customer = customerRepository.ExtraerInfoCliente(customerData);

                // Mostrar los datos del cliente en un DataGridView o donde desees
                gridTipado.DataSource = new List<Customer> { customer };
            }
            else
            {
                // Si no se encuentran datos, mostrar un mensaje al usuario
                MessageBox.Show("Cliente no encontrado.");
                gridTipado.DataSource = null;  // Limpia la grilla si no hay datos
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }
    }
}
