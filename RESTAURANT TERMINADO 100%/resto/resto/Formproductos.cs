﻿using System;
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
			CargarGrilla();
			txt_cantidad.Text = "1";
			
		}
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
			decimal cantidad = Convert.ToDecimal(txt_cantidad.Text);
			decimal precio = Convert.ToDecimal(txt_precio.Text);
			if (cantidad > 0 && precio > 0)
			{
				Producto objprod = new Producto();
				objprod.ProdId 		= int.Parse(grid_prod.SelectedRows[0].Cells["prod_id"].Value.ToString());
				objprod.ProdNombre 	= grid_prod.SelectedRows[0].Cells["prod_nombre"].Value.ToString();
				objprod.ProdPrecio = float.Parse(grid_prod.SelectedRows[0].Cells["prod_precio"].Value.ToString());
				objprod.ProdNumero 		= int.Parse(grid_prod.SelectedRows[0].Cells["prod_numero"].Value.ToString());
				string prod_id = grid_prod.SelectedRows[0].Cells["prod_id"].Value.ToString();
				miConexion.EjecutarSentencia(string.Format("exec InsertOrUpdateMesaProducto {0},'{1}','{2}',{3}", mesa_id,prod_id,  txt_cantidad.Text,txt_precio.Text));
			}
			else
			{
				// Mostrar un mensaje de error indicando que los valores no son válidos
				MessageBox.Show("La cantidad y el precio deben ser valores positivos y mayores que cero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void Btn_cerrarClick(object sender, EventArgs e)
		{
			this.Close();
			
		}
	}
}
