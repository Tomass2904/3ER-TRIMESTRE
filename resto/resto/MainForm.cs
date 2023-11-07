/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 07/11/2023
 * Time: 8:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace resto
{
	
	public partial class MainForm : Form
	{
		ClassConexionSQL miConexion;
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		void Btn_mesa1Click(object sender, EventArgs e)
		{
			FormCARGAR formcar = new FormCARGAR();
			formcar.ShowDialog();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
