using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace resto
{
	
	public partial class Formproductos : Form
	{
		ClassConexionSQL miConexion;
		int mesa_id=0;
		BindingSource bs = new BindingSource();
		
		public Formproductos(int fmesa_id)
		{
			InitializeComponent();
			mesa_id=fmesa_id;
			grid_prod.SelectionChanged += GridProd_SelectionChanged;

		}
		void FormproductosLoad(object sender, EventArgs e)
		{
			miConexion = new ClassConexionSQL();
			miConexion.CrearConexion();
//			string consulta = "select * from productos ";
//			miConexion.LLenarGrid(ref grid_prod,consulta);
			CargarGrilla();
			txt_cantidad.Text = "1";
			
			

		}

		// Evento para manejar el cambio de selección en la grilla
		private void GridProd_SelectionChanged(object sender, EventArgs e)
		{
			if (grid_prod.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = grid_prod.SelectedRows[0];

				// Asegúrate de cambiar "prod_precio" por el nombre real de la columna en tu grilla
				object precio = selectedRow.Cells["prod_precio"].Value;

				if (precio != null)
				{
					txt_precio.Text = precio.ToString();
				}
			}
		}
		void CargarGrilla()
		{
			DataSet ds = miConexion.EjecutarSentencia("exec sp_obtener_productos");
			bs.DataSource = ds.Tables[0];
			grid_prod.DataSource = bs;

			txt_buscar.TextChanged += FiltrarGrillaPorTexto;
		}
		void FiltrarGrillaPorTexto(object sender, EventArgs e)
		{
			if (bs.DataSource != null && bs.DataSource is DataTable)
			{
				DataTable dt = (DataTable)bs.DataSource;
				string filtro = txt_buscar.Text;

				int numero;
				if (int.TryParse(filtro, out numero))
				{
					// Filtrar por número solo si el texto es numérico
					DataView dv = new DataView(dt);
					dv.RowFilter = "Convert(prod_numero, 'System.String') LIKE '" + filtro + "'";
					grid_prod.DataSource = dv;
				}
				else
				{
					// Si no es numérico, filtra por prod_nombre
					DataView dv = new DataView(dt);
					dv.RowFilter = "prod_nombre LIKE '" + filtro + "'";
					grid_prod.DataSource = dv;
				}
			}
		}






		void Btn_cargarClick(object sender, EventArgs e)
		{
			Producto objprod = new Producto();
			objprod.ProdId 		= int.Parse(grid_prod.SelectedRows[0].Cells["prod_id"].Value.ToString());
			objprod.ProdNombre 	= grid_prod.SelectedRows[0].Cells["prod_nombre"].Value.ToString();
			objprod.ProdPrecio = float.Parse(grid_prod.SelectedRows[0].Cells["prod_precio"].Value.ToString());
			objprod.ProdNumero 		= int.Parse(grid_prod.SelectedRows[0].Cells["prod_numero"].Value.ToString());
			string prod_id = grid_prod.SelectedRows[0].Cells["prod_id"].Value.ToString();
			miConexion.EjecutarSentencia(string.Format("exec SP_insertar_mesa_prod {0},'{1}','{2}',{3}", prod_id, txt_precio.Text, txt_cantidad.Text, mesa_id));


		}
		
	}
}
