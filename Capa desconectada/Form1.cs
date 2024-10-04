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
        private void RellenarForm(Customer cliente)
        {
            if (cliente != null)
            {
                tboxCustomerID.Text = cliente.CustomerID;
                tboxCompanyName.Text = cliente.CompanyName;
                tboxContactName.Text = cliente.ContactName;
                tboxContactTitle.Text = cliente.ContactTitle;
                tboxAddres.Text = cliente.Address;
            }
            if (cliente == null)
            {
                MessageBox.Show("objeto null ");
            }
        }

        #region No Tipado 
        private CustomerRepository customerRepository = new CustomerRepository();
        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            gridNotipado.DataSource = customerRepository.ObtenerTodos();
        }
        private void btnBuscarNt_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.obtenerPorID(tbBusquedaNt.Text);
            RellenarForm(cliente);
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
        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = customerRepository.InsertarCliente(cliente);
            MessageBox.Show($"{insertados} cliente registrado");
        }
        private Customer CrearCliente()
        {
            var cliente = new Customer
            {
                CustomerID = tboxCustomerID.Text,
                CompanyName = tboxCompanyName.Text,
                ContactName = tboxContactName.Text,
                ContactTitle = tboxContactTitle.Text,
                Address = tboxAddres.Text,
            };

            return cliente;
        }

        private void btnActualizarNT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            var actualizadas = customerRepository.ActualizarCliente(cliente);
            MessageBox.Show($"{actualizadas} filas actualizadas");
            gridTipado.DataSource = adaptador.GetData();
            gridNotipado.DataSource = customerRepository.ObtenerTodos();
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
                RellenarForm(customer);
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

        private void btnInsertarT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            adaptador.Insert(cliente.CustomerID, cliente.CompanyName, cliente.ContactName, cliente.ContactTitle, cliente.Address, cliente.City, cliente.Region, cliente.PostalCode, cliente.Country, cliente.Phone,
                cliente.Fax
                );
            MessageBox.Show($"Cliente registrado");
            gridTipado.DataSource = adaptador.GetData();
            gridNotipado.DataSource = customerRepository.ObtenerTodos();
        }

        private void btnActualizarT_Click(object sender, EventArgs e)
        {
            var fila = adaptador.GetDataByCustomerID(tboxCustomerID.Text);

            if (fila != null)
            {
                var datoOriginal = customerRepository.ExtraerInfoCliente(fila);
                var datosModificados = CrearCliente();
                var filas = adaptador.Update(
                    datosModificados.CustomerID,
                    datosModificados.CompanyName,
                    datosModificados.ContactName,
                    datosModificados.ContactTitle,
                    datosModificados.Address,
                    datosModificados.City,
                    datosModificados.Region,
                    datosModificados.PostalCode,
                    datosModificados.Country,
                    datosModificados.Phone,
                    datosModificados.Fax,
                    datoOriginal.CustomerID,
                    datoOriginal.CompanyName,
                    datoOriginal.ContactName,
                    datoOriginal.ContactTitle,
                    datoOriginal.Address,
                    datoOriginal.City,
                    datoOriginal.Region,
                    datoOriginal.PostalCode,
                    datoOriginal.Country,
                    datoOriginal.Phone,
                    datoOriginal.Fax
                    );

                MessageBox.Show($"{filas} filas modificadas");
                gridTipado.DataSource = adaptador.GetData();
                gridNotipado.DataSource = customerRepository.ObtenerTodos();
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

    }
}
