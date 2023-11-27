using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace resto
{
	
	public partial class MainForm : Form
	{
		ClassConexionSQL miConexion;
		BindingSource bs = new BindingSource();
		
		public MainForm()
		{
			
			InitializeComponent();
			btn_cargar_prod.Visible=true;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			miConexion = new ClassConexionSQL();
			miConexion.CrearConexion();
			string consulta = "select * from mesas ";
			miConexion.LLenarGrid(ref gridmesas,consulta);
			CargarGrilla();
			
		}
		void Btn_cargar_mesasClick(object sender, EventArgs e)
		{
			FormCARGAR formcar = new FormCARGAR();
			formcar.ShowDialog();
		}
		void CargarGrilla(){
			DataSet ds = miConexion.EjecutarSentencia("exec sp_obtener_mesas");
			bs.DataSource = ds.Tables[0];
			gridmesas.DataSource = bs;
		}
		void Btn_eliminar_mesasClick(object sender, EventArgs e)
		{
			string ID = gridmesas.SelectedRows[0].Cells["mesa_id"].Value.ToString();
			miConexion.EjecutarSentencia("exec sp_eliminar_mesas " + ID);
			CargarGrilla();
		}
		
		void mesas_click(object sender, EventArgs e)
		{
			string ID = gridmesas.SelectedRows[0].Cells["mesa_id"].Value.ToString();
			Formproductos formprod = new Formproductos(Convert.ToInt32(ID));
			formprod.ShowDialog();
			
		}
		void prod_cargados(object sender, EventArgs e)
		{
			DataSet ds = miConexion.EjecutarSentencia("exec sp_obtener_mesa_prod");
			bs.DataSource = ds.Tables[0];
			grid_prod_mesas.DataSource = bs;
		}
		
		
		
		
		
		
			
		
	}
}
