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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            OleDbConnection objConexion = new OleDbConnection();
            try
            {
                if (TxtApell.Text == "" | TxtNom.Text == "" | TxtCar.Text == "" | TxtTrat.Text == "" | TxtDirec.Text == "" | TxtCiu.Text == "" | TxtReg.Text == "" | TxtCodi.Text == "" | TxtPais.Text == "" | TxtTel.Text == "" | TxtExten.Text == "" | TxtNotas.Text == "" | CmbJefes.SelectedItem == null) 
                {
                    MessageBox.Show("Por favor ingrese todos los datos sobre el empleado.", "Datos incompletos");
                }
                else
                {
                    String Ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                    objConexion.ConnectionString = Ruta;
                    objConexion.Open();
                    String Dat = "INSERT INTO Empleados (Apellidos, Nombre, Cargo, Tratamiento, FechaNacimiento, FechaContratación, Dirección, Ciudad, Región, CódPostal, País, TelDomicilio, Extensión,Foto, Notas, Jefe) VALUES(";

                    Dat += "'" + TxtApell.Text + "', ";
                    Dat += "'" + TxtNom.Text + "', ";
                    Dat += "'" + TxtCar.Text + "', ";
                    Dat += "'" + TxtTrat.Text + "', ";
                    Dat += "'" + DTPUno.Value + "', ";
                    Dat += "'" + DTPDos.Value + "', ";
                    Dat += "'" + TxtDirec.Text + "', ";
                    Dat += "'" + TxtCiu.Text + "', ";
                    Dat += "'" + TxtReg.Text + "', ";
                    Dat += "'" + TxtCodi.Text + "', ";
                    Dat += "'" + TxtPais.Text + "', ";
                    Dat += "'" + TxtTel.Text + "', ";
                    Dat += "'" + TxtExten.Text + "', ";
                    Dat += "'" + PtbEpli.Image + "', ";
                    Dat += "'" + TxtNotas.Text + "', ";
                    Dat += "'" + CmbJefes.SelectedIndex + "') ";
                    OleDbCommand ObjComando = new OleDbCommand();
                    ObjComando.Connection = objConexion;
                    ObjComando.CommandText = @Dat;
                    ObjComando.ExecuteNonQuery();
                    MessageBox.Show("El empleado se registro", "Epleado Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objConexion.Close();
                    TxtApell.Text = "";
                    TxtNom.Text = "";
                    TxtCar.Text = "";
                    TxtTrat.Text = "";
                    DTPUno.Text = "";
                    DTPDos.Text = "";
                    TxtDirec.Text = "";
                    TxtCiu.Text = "";
                    TxtReg.Text = "";
                    TxtCodi.Text = "";
                    TxtPais.Text = "";
                    TxtTel.Text = "";
                    TxtExten.Text = "";
                    PtbEpli.Image = null;
                    TxtNotas.Text = "";
                    CmbJefes.SelectedIndex = -1;
                }

               

            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                throw;
            }
           
        }

        private void PtbEpli_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1.Filter = "images files (*.jpg;*.jpeg.;*.png)|";
            this.openFileDialog1.ShowDialog();
            PtbEpli.ImageLocation = openFileDialog1.FileName;
        }
    }
}
