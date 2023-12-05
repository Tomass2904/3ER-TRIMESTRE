using System;
using System.Drawing;
using System.Windows.Forms;

namespace resto
{
	
	public partial class FormCARGAR : Form
	{
		ClassConexionSQL miConexion;
		public FormCARGAR()
		{
			
			InitializeComponent();
			
		}	
		void FormCARGARLoad(object sender, EventArgs e)
		{
			miConexion = new ClassConexionSQL();
			miConexion.CrearConexion();	
		}
		void Btn_cargarClick(object sender, EventArgs e)
		{
			miConexion.EjecutarSentencia(string.Format("exec sp_cargar_mesas {0},{1},{2},'{3}'",txt_numero.Text, txt_capacidad.Text, txt_estado.Text, txt_descripcion.Text));
			Close();
			
		}
	}
}
