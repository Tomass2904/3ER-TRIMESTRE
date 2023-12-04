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
			Formlogin formlog = new Formlogin();
			formlog.ShowDialog();
			grid_prod_mesas.AutoGenerateColumns=false;
			miConexion = new ClassConexionSQL();
			miConexion.CrearConexion();
			string consulta = "select * from mesas ";
			miConexion.LLenarGrid(ref gridmesas,consulta);
			CargarGrilla();
			string consulta1 = "select * from mesas_productos ";
			miConexion.LLenarGrid(ref grid_prod_mesas,consulta1);
//			CargarGrillaMesaProd();
			gridmesas.SelectionChanged += Gridmesas_SelectionChanged;
			gridmesas.CellFormatting += gridmesas_CellFormatting;
			
			
		}
		void Btn_cargar_mesasClick(object sender, EventArgs e)
		{
			FormCARGAR formcar = new FormCARGAR();
			formcar.ShowDialog();
			CargarGrilla();
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
		private void Gridmesas_SelectionChanged(object sender, EventArgs e)
		{
			if (gridmesas.SelectedRows.Count > 0)
			{
				// Obtener el ID de la mesa seleccionada
				string mesaId = gridmesas.SelectedRows[0].Cells["mesa_id"].Value.ToString();

				// Llamar al procedimiento almacenado para obtener los productos de esa mesa
				DataSet dsProductosMesa = miConexion.EjecutarSentencia("exec sp_obtener_mesa_producto " + mesaId);

				// Actualizar grid_prod_mesas con los datos obtenidos
				if (dsProductosMesa != null && dsProductosMesa.Tables.Count > 0)
				{
					BindingSource bsProductosMesa = new BindingSource();
					bsProductosMesa.DataSource = dsProductosMesa.Tables[0];
					grid_prod_mesas.DataSource = bsProductosMesa;
				}
			}
		}
		void BtnCargarProductosClick(object sender, EventArgs e)
		{
			string mesaId = gridmesas.SelectedRows[0].Cells["mesa_id"].Value.ToString();
			Formproductos formprod = new Formproductos(Convert.ToInt32(mesaId));
			formprod.ShowDialog();
			miConexion.EjecutarSentencia(string.Format("exec sp_obtener_mesa_producto " + mesaId));
			
			Gridmesas_SelectionChanged(null,e);
			
		}
		void Btn_eliminar_prodClick(object sender, EventArgs e)
		{
			string ID = grid_prod_mesas.SelectedRows[0].Cells["mepr_id"].Value.ToString();
			miConexion.EjecutarSentencia("exec sp_eliminar_mesa_producto "+ID);
			Gridmesas_SelectionChanged(null,e);
		}
		private void gridmesas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// Verificar si la columna actual es la de 'mesa_estado' (suponiendo que está en la posición 3)
			if (e.ColumnIndex == 3 && e.RowIndex >= 0) // Asegúrate de que no sea el encabezado de la columna
			{
				// Obtener el valor de la celda actual en la columna 'mesa_estado'
				var valorCelda = (bool)gridmesas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

				// Comprobar si el estado es 0 (negativo)
				if (!valorCelda) // Suponiendo que 'false' representa el estado negativo
				{
					// Cambiar el color de fondo de la fila a rojo
					gridmesas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
					gridmesas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White; // Cambiar el color del texto si es necesario
				}
				else
				{
					// Restaurar los colores predeterminados si el estado no es 0
					gridmesas.Rows[e.RowIndex].DefaultCellStyle.BackColor = gridmesas.DefaultCellStyle.BackColor;
					gridmesas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = gridmesas.DefaultCellStyle.ForeColor;
				}
			}
		}
		// Agrega esta función en tu MainForm
		void BtnEliminarProductosClick(object sender, EventArgs e)
		{
			if (grid_prod_mesas.SelectedRows.Count > 0)
			{
				// Obtener el ID del producto seleccionado en la grilla
				string productoId = grid_prod_mesas.SelectedRows[0].Cells["Column"].Value.ToString();

				// Llamar al método para eliminar el producto
				EliminarProducto(productoId);
			}
			else
			{
				MessageBox.Show("Selecciona un producto para eliminar.");
			}
		}

		// Método para eliminar un producto por su ID
		void EliminarProducto(string productoId)
		{
			DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Eliminar Producto", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				// Llamar al método en la clase de conexión para ejecutar el stored procedure
				miConexion.EjecutarSentencia("exec sp_eliminar_mesa_producto " + productoId);

				// Actualizar la grilla después de eliminar el producto
				Gridmesas_SelectionChanged(null, EventArgs.Empty);
			}
		}
	}
}

