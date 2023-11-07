using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace login
{

	public partial class MainForm : Form
	{
		ClassConexionSQL miConexion;
		public MainForm()
		{

			InitializeComponent();

		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			miConexion = new ClassConexionSQL();
			miConexion.CrearConexion();
		}
		
		
		void Btn_loginClick(object sender, EventArgs e)
		{
			if (miConexion.ValidarUsuario(txt_usu.Text,txt_pass.Text)){
				//MessageBox.Show("ok");
				FormAlumno frmalumno = new FormAlumno();
				frmalumno.Show();
				this.Hide();
			}else{
				MessageBox.Show("Datos erroneos");
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
				FormAlumno frmalumno = new FormAlumno();
				frmalumno.Show();
				this.Hide();			
		}
	}
}