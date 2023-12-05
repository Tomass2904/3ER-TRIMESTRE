using System;
using System.Drawing;
using System.Windows.Forms;

namespace resto
{
	/// <summary>
	/// Description of Formlogin.
	/// </summary>
	public partial class Formlogin : Form
	{
		ClassConexionSQL miConexion;
		public Formlogin()
		{
			InitializeComponent();
		}
		void FormloginLoad(object sender, EventArgs e)
		{
			miConexion = new ClassConexionSQL();
			miConexion.CrearConexion();
		}
		
		void Btn_loginClick(object sender, EventArgs e)
		{
			if (miConexion.ValidarUsuario(txt_usu.Text,txt_pass.Text)){
				this.Hide();
			}else{
				MessageBox.Show("Datos erroneos");
				Environment.Exit(0); 
			}
		}
		
	}
}
