using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace login
{
	public partial class FormAlumno : Form
	{
		ClassConexionSQL miConexion;
		BindingSource bs = new BindingSource();
		public FormAlumno()
		{

			InitializeComponent();
			
		}
		void CargarGrilla(){
			DataSet ds = miConexion.EjecutarSentencia("exec sp_obtener_alumnos");
			bs.DataSource = ds.Tables[0];
			gridDatos.DataSource = bs;
		}
		
		void FormAlumnoLoad(object sender, EventArgs e)
		{
//			gridDatos.AutoGenerateColumns = false;
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
			Alumno objAlumno = new Alumno();
			Formingresar formingr = new Formingresar(objAlumno);
			formingr.Ingresar = true;
			formingr.ShowDialog();
			CargarGrilla();
		}
		void Btn_eliminarClick(object sender, EventArgs e)
		{
			string ID = gridDatos.SelectedRows[0].Cells["alum_id"].Value.ToString();
			miConexion.EjecutarSentencia("exec sp_eliminar_alumnos " + ID);
			
			CargarGrilla();
		}
		void Btn_modificarClick(object sender, EventArgs e)
		{
			//tomar todos los valores de la grilla y crear un objeto alumno
			Alumno objAlumno = new Alumno();
			objAlumno.alum_id 		= int.Parse(gridDatos.SelectedRows[0].Cells["alum_id"].Value.ToString());
			objAlumno.alum_nombre 	= gridDatos.SelectedRows[0].Cells["alum_nombre"].Value.ToString();
			objAlumno.alum_apellido = gridDatos.SelectedRows[0].Cells["alum_apellido"].Value.ToString();
			objAlumno.alum_dni 		= gridDatos.SelectedRows[0].Cells["alum_dni"].Value.ToString();
			objAlumno.alum_edad 	= int.Parse(gridDatos.SelectedRows[0].Cells["alum_edad"].Value.ToString());
			objAlumno.alum_email 	= gridDatos.SelectedRows[0].Cells["alum_email"].Value.ToString();
			
			Formingresar formingr = new Formingresar(objAlumno);
			formingr.ShowDialog();
		}
		
	}
}