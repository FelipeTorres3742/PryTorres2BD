using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace PryTorresBD
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }
         OleDbConnection ObjConexion;
        OleDbDataAdapter ObjAdapatador;
        DataSet ObjDataSet;
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ObjConexion = new OleDbConnection();

            try
            {
                String Ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                ObjConexion.ConnectionString = Ruta;
                ObjConexion.Open();

                ObjAdapatador = new OleDbDataAdapter();
                ObjDataSet=new DataSet();

                string consulta;

                if (CmbConsulta.SelectedIndex == 0)
                {
                    consulta = "Select *From Categorías";
                    ObjAdapatador = new OleDbDataAdapter(consulta, ObjConexion);
                    ObjDataSet.Tables.Add("Categorías");
                    ObjAdapatador.Fill(ObjDataSet.Tables["Categorías"]);
                    DGVTabla.DataSource = ObjDataSet.Tables["Categorías"];

                }
                else if (CmbConsulta.SelectedIndex == 1)
                {
                    consulta = "Select *From Clientes";
                    ObjAdapatador = new OleDbDataAdapter(consulta, ObjConexion);
                    ObjDataSet.Tables.Add("Clientes");
                    ObjAdapatador.Fill(ObjDataSet.Tables["Clientes"]);
                    DGVTabla.DataSource = ObjDataSet.Tables["Clientes"];
                }
                else if (CmbConsulta.SelectedIndex == 2) 
                {
                    consulta = "Select *From [Detalles de pedidos]";
                    ObjAdapatador = new OleDbDataAdapter(consulta, ObjConexion);
                    ObjDataSet.Tables.Add("Detalles de pedidos");
                    ObjAdapatador.Fill(ObjDataSet.Tables["Detalles de pedidos"]);
                    DGVTabla.DataSource = ObjDataSet.Tables["Detalles de pedidos"];

                }
                else if(CmbConsulta.SelectedIndex == 3)
                {
                    consulta = "Select IdEmpleado,Apellidos,Nombre,Cargo,Tratamiento,FechaNacimiento,"+"FechaContratación,Dirección,Ciudad,Región,CódPostal,País,TelDomicilio,Extensión,"+"Notas,Jefe From Empleados";
                    ObjAdapatador = new OleDbDataAdapter(consulta, ObjConexion);
                    ObjDataSet.Tables.Add("Empleados");
                    ObjAdapatador.Fill(ObjDataSet.Tables["Empleados"]);
                    DGVTabla.DataSource = ObjDataSet.Tables["Empleados"];
                }
                else if(CmbConsulta.SelectedIndex == 4)
                {
                    consulta = "Select *From Pedidos";
                    ObjAdapatador = new OleDbDataAdapter(consulta, ObjConexion);
                    ObjDataSet.Tables.Add("Pedidos");
                    ObjAdapatador.Fill(ObjDataSet.Tables["Pedidos"]);
                    DGVTabla.DataSource = ObjDataSet.Tables["Pedidos"];
                }
                else if(CmbConsulta.SelectedIndex == 5)
                {
                    consulta = "Select *From Productos";
                    ObjAdapatador = new OleDbDataAdapter(consulta, ObjConexion);
                    ObjDataSet.Tables.Add("Productos");
                    ObjAdapatador.Fill(ObjDataSet.Tables["Productos"]);
                    DGVTabla.DataSource = ObjDataSet.Tables["Productos"];
                }
                else if (CmbConsulta.SelectedIndex == 6)
                {
                    consulta = "Select *From Proveedores";
                    ObjAdapatador = new OleDbDataAdapter(consulta, ObjConexion);
                    ObjDataSet.Tables.Add("Proveedores");
                    ObjAdapatador.Fill(ObjDataSet.Tables["Proveedores"]);
                    DGVTabla.DataSource = ObjDataSet.Tables["Proveedores"];
                }
                       
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                throw;
            }
        }

        private void DGVTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
