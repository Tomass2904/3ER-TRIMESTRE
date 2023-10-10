/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 09/10/2023
 * Time: 20:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
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
				MessageBox.Show("ok");
			}else{
				MessageBox.Show("Datos erroneos");
			}
		}
	}
}
