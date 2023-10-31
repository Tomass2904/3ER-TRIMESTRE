using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	public partial class FormAlumno : Form
	{
		ClassConexionSQL miConexion;
		public FormAlumno()
		{

			InitializeComponent();
			
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
		
		void Btn_ingresarClick(object sender, EventArgs e)
		{
			miConexion.EjecutarSentencia("exec SP_Ingresar_Alumnos");
		}
	}
}
