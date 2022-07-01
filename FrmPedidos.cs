using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PryTorresBD
{
    public partial class FrmParametros : Form
    {
        public FrmParametros()
        {
            InitializeComponent();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection ObjConexion = new OleDbConnection();
                ObjConexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                ObjConexion.Open();
                string Dat;
                OleDbCommand ObjComando;
                OleDbDataAdapter Adaptador = new OleDbDataAdapter();

                Dat = "Select * From Pedidos WHERE FechaPedido BETWEEN @fechadesde AND @fechahasta";
                ObjComando = new OleDbCommand(Dat, ObjConexion);
                ObjComando.Parameters.AddWithValue("@fechadesde", DTPFecha.Value.Date);
                ObjComando.Parameters.AddWithValue("@fechahasta", DTPFechaFin.Value.Date);
                Adaptador.SelectCommand= ObjComando;
                DataSet dataSet = new DataSet();
                Adaptador.Fill(dataSet,"tabla");
                DGVResult.DataSource = dataSet;
                DGVResult.DataMember = "tabla";
                ObjConexion.Close();   
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmParametros_Load(object sender, EventArgs e)
        {
            OleDbConnection ObjConexion = new OleDbConnection();
            ObjConexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
            ObjConexion.Open();
            string Dat;
            OleDbCommand comando;
            OleDbDataAdapter Adapatador = new OleDbDataAdapter();
            Dat = "SELECT Clientes.IdCliente,Pedidos.CiudadDestinatario,Pedidos.RegiónDestinatario,Pedidos.CódPostalDestinatario, " + "Pedidos.PaísDestinatario FROM Clientes,Pedidos";
            comando = new OleDbCommand(Dat , ObjConexion);
            OleDbDataReader dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                if (!CmbNom.Items.Contains(dataReader["IdCliente"].ToString()))
                {
                    CmbNom.Items.Add(dataReader["IdCliente"].ToString());
                }
                if (!CmbCiu.Items.Contains(dataReader["CiudadDestinatario"].ToString()))
                {
                    CmbCiu.Items.Add(dataReader["CiudadDestinatario"].ToString());
                }
                if (!CmbReg.Items.Contains(dataReader["RegiónDestinatario"].ToString())& dataReader["RegiónDestinatario"].ToString()!="")
                {
                    CmbReg.Items.Add(dataReader["RegiónDestinatario"].ToString());
                }
                if (!CmbCod.Items.Contains(dataReader["CódPostalDestinatario"].ToString())& dataReader["CódPostalDestinatario"].ToString()!="")
                { 
                    CmbCod.Items.Add(dataReader["CódPostalDestinatario"].ToString());
                }
                if (!CmbPais.Items.Contains(dataReader["PaísDestinatario"].ToString()))
                {
                    CmbPais.Items.Add(dataReader["PaísDestinatario"].ToString());
                }
            }
            ObjConexion.Close();
        }

        private void BtnNom_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection ObjConexion = new OleDbConnection();
                ObjConexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                ObjConexion.Open();
                string Dat;
                OleDbCommand ObjComando;
                OleDbDataAdapter Adaptador = new OleDbDataAdapter();
                Dat = "Select * From Pedidos WHERE IdCliente = @Nombre";
                ObjComando = new OleDbCommand(Dat, ObjConexion);
                ObjComando.Parameters.AddWithValue("@Nombre", CmbNom.SelectedItem.ToString());
                Adaptador.SelectCommand = ObjComando;
                DataSet dataSet = new DataSet();
                Adaptador.Fill(dataSet, "tabla");
                DGVResult.DataSource = dataSet;
                DGVResult.DataMember = "tabla";
                ObjConexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        private void btnCui_Click(object sender, EventArgs e)
        {
            OleDbConnection ObjConexion = new OleDbConnection();
            ObjConexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
            ObjConexion.Open();
            string Dat;
            OleDbCommand ObjComando;
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            Dat = "Select * From Pedidos WHERE CiudadDestinatario = @Ciudad";
            ObjComando = new OleDbCommand(Dat, ObjConexion);
            ObjComando.Parameters.AddWithValue("@Ciudad", CmbCiu.SelectedItem.ToString());
            Adaptador.SelectCommand = ObjComando;
            DataSet dataSet = new DataSet();
            Adaptador.Fill(dataSet, "tabla");
            DGVResult.DataSource = dataSet;
            DGVResult.DataMember = "tabla";
            ObjConexion.Close();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            OleDbConnection ObjConexion = new OleDbConnection();
            ObjConexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
            ObjConexion.Open();
            string Dat;
            OleDbCommand ObjComando;
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            Dat = "Select * From Pedidos WHERE RegiónDestinatario = @Region";
            ObjComando = new OleDbCommand(Dat, ObjConexion);
            ObjComando.Parameters.AddWithValue("@Region", CmbReg.SelectedItem.ToString());
            Adaptador.SelectCommand = ObjComando;
            DataSet dataSet = new DataSet();
            Adaptador.Fill(dataSet, "tabla");
            DGVResult.DataSource = dataSet;
            DGVResult.DataMember = "tabla";
            ObjConexion.Close();
        }

        private void BtnCod_Click(object sender, EventArgs e)
        {
            OleDbConnection ObjConexion = new OleDbConnection();
            ObjConexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
            ObjConexion.Open();
            string Dat;
            OleDbCommand ObjComando;
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            Dat = "Select * From Pedidos WHERE CódPostalDestinatario = @CodigoPos";
            ObjComando = new OleDbCommand(Dat, ObjConexion);
            ObjComando.Parameters.AddWithValue("@CodigoPos", CmbCod.SelectedItem.ToString());
            Adaptador.SelectCommand = ObjComando;
            DataSet dataSet = new DataSet();
            Adaptador.Fill(dataSet, "tabla");
            DGVResult.DataSource = dataSet;
            DGVResult.DataMember = "tabla";
            ObjConexion.Close();
        }

        private void btnPais_Click(object sender, EventArgs e)
        {
            OleDbConnection ObjConexion = new OleDbConnection();
            ObjConexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
            ObjConexion.Open();
            string Dat;
            OleDbCommand ObjComando;
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            Dat = "Select * From Pedidos WHERE PaísDestinatario = @Pais";
            ObjComando = new OleDbCommand(Dat, ObjConexion);
            ObjComando.Parameters.AddWithValue("@Pais", CmbPais.SelectedItem.ToString());
            Adaptador.SelectCommand = ObjComando;
            DataSet dataSet = new DataSet();
            Adaptador.Fill(dataSet, "tabla");
            DGVResult.DataSource = dataSet;
            DGVResult.DataMember = "tabla";
            ObjConexion.Close();
        }

        private void BtnCar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection ObjConexion = new OleDbConnection();
                ObjConexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                ObjConexion.Open();
                string Dat;
                OleDbCommand ObjComando;
                OleDbDataAdapter Adaptador = new OleDbDataAdapter();

                Dat = "Select * From Pedidos WHERE Cargo BETWEEN @NudMin AND @NudMax";
                ObjComando = new OleDbCommand(Dat, ObjConexion);
                ObjComando.Parameters.AddWithValue("@NudMin", NudMin.Value);
                ObjComando.Parameters.AddWithValue("@NudMax", NudMax.Value);
                Adaptador.SelectCommand = ObjComando;
                DataSet dataSet = new DataSet();
                Adaptador.Fill(dataSet, "tabla");
                DGVResult.DataSource = dataSet;
                DGVResult.DataMember = "tabla";
                ObjConexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
