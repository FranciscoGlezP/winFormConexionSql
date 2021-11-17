using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormConexionSql
{
    public partial class Form1 : Form
    {

        #region Propiedades
        private MySql.Data.MySqlClient.MySqlConnection conexion;
        #endregion Propiedades

        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Eventos
        private void btnPruebaConexion_Click(object sender, EventArgs e)
        {
            try
            {
                conexion = new MySql.Data.MySqlClient.MySqlConnection();
                conexion.ConnectionString = string.Format("server={0};uid={1};pwd={2};database={3}",
                               txtHost.Text,txtUser.Text,txtPw.Text,txtBD.Text);
                conexion.Open();
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("¡Conexion Exitosa!");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error de Conexion: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }
        #endregion Eventos
    }
}
