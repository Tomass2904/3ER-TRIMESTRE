/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 30/10/2023
 * Time: 20:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of FormAlumno.
	/// </summary>
	public partial class FormAlumno : Form
	{
				ClassConexionSQL miConexion;
		public FormAlumno()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FormAlumnoLoad(object sender, EventArgs e)
		{
			miConexion = new ClassConexionSQL();
			miConexion.CrearConexion();		
			string consulta = "select * from alumnos ";
			miConexion.LLenarGrid(ref gridDatos,consulta);
		}
		
//		void Button3Click(object sender, EventArgs e)
//		{
//			miConexion.EjecutarSentencia("exec SP_eliminar_alumno")
//		}
	}
}
