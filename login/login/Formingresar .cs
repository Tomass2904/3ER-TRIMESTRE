using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of Formingresar.
	/// </summary>
	public partial class Formingresar : Form
	{
		public bool Ingresar=false;
		ClassConexionSQL miConexion;
		public Alumno DataAlumno;
		public Formingresar(Alumno OAlumno)
		{
			DataAlumno = OAlumno;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Btn_ingresarClick(object sender, EventArgs e)
		{

			
			
			if (Ingresar){

				miConexion.EjecutarSentencia(string.Format("exec SP_Ingresar_Alumnos '{0}','{1}','{2}',{3},'{4}'",txt_nombre.Text, txt_apellido.Text, txt_dni.Text, txt_edad.Text, txt_email.Text));
			}else{//modificar
				miConexion.EjecutarSentencia(string.Format("exec SP_modificar_Alumnos '{0}','{1}','{2}',{3},'{4}'",txt_nombre.Text, txt_apellido.Text, txt_dni.Text, txt_edad.Text, txt_email.Text));
			}
			
			
		}
		void FormingresarLoad(object sender, EventArgs e)
		{
			if(!Ingresar){ //si modificar true
				txt_nombre.Text = DataAlumno.alum_nombre;
				txt_apellido.Text = DataAlumno.alum_apellido;
				txt_dni.Text = DataAlumno.alum_dni;
				txt_edad.Text = Convert.ToString(DataAlumno.alum_edad);
				txt_email.Text = DataAlumno.alum_email;
			}
			miConexion = new ClassConexionSQL();
			miConexion.CrearConexion();
		}
		void Btn_modificarClick(object sender, EventArgs e)
		{
			miConexion.EjecutarSentencia(string.Format("exec SP_Actualizar_Alumnos {0},{1},{2},{3},{4}",txt_nombre.Text, txt_apellido.Text, txt_dni.Text, txt_edad.Text, txt_email.Text));
		}
	}
}
