/*
 * Created by SharpDevelop.
 * User: TOMAS
 * Date: 23/11/2023
 * Time: 15:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace resto
{
	partial class Formproductos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_buscar;
		private System.Windows.Forms.TextBox txt_buscar;
		private System.Windows.Forms.Button btn_cargar;
		private System.Windows.Forms.DataGridView grid_prod;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txt_precio;
		private System.Windows.Forms.Label lbl_precio;
		private System.Windows.Forms.TextBox txt_cantidad;
		private System.Windows.Forms.Label lbl_cantidad;
		private System.Windows.Forms.Button btn_cerrar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_cerrar = new System.Windows.Forms.Button();
			this.txt_buscar = new System.Windows.Forms.TextBox();
			this.lbl_buscar = new System.Windows.Forms.Label();
			this.grid_prod = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt_cantidad = new System.Windows.Forms.TextBox();
			this.lbl_cantidad = new System.Windows.Forms.Label();
			this.txt_precio = new System.Windows.Forms.TextBox();
			this.lbl_precio = new System.Windows.Forms.Label();
			this.btn_cargar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_prod)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.panel1.Controls.Add(this.btn_cerrar);
			this.panel1.Controls.Add(this.txt_buscar);
			this.panel1.Controls.Add(this.lbl_buscar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1006, 54);
			this.panel1.TabIndex = 8;
			// 
			// btn_cerrar
			// 
			this.btn_cerrar.BackColor = System.Drawing.Color.Red;
			this.btn_cerrar.Location = new System.Drawing.Point(894, 15);
			this.btn_cerrar.Name = "btn_cerrar";
			this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_cerrar.TabIndex = 9;
			this.btn_cerrar.Text = "CERRAR";
			this.btn_cerrar.UseVisualStyleBackColor = false;
			this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrarClick);
			// 
			// txt_buscar
			// 
			this.txt_buscar.Location = new System.Drawing.Point(77, 15);
			this.txt_buscar.Name = "txt_buscar";
			this.txt_buscar.Size = new System.Drawing.Size(288, 20);
			this.txt_buscar.TabIndex = 8;
			// 
			// lbl_buscar
			// 
			this.lbl_buscar.Location = new System.Drawing.Point(0, 15);
			this.lbl_buscar.Name = "lbl_buscar";
			this.lbl_buscar.Size = new System.Drawing.Size(100, 23);
			this.lbl_buscar.TabIndex = 7;
			this.lbl_buscar.Text = "BUSCAR";
			// 
			// grid_prod
			// 
			this.grid_prod.AllowUserToAddRows = false;
			this.grid_prod.AllowUserToDeleteRows = false;
			this.grid_prod.AllowUserToOrderColumns = true;
			this.grid_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.grid_prod.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid_prod.Location = new System.Drawing.Point(0, 54);
			this.grid_prod.Name = "grid_prod";
			this.grid_prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_prod.Size = new System.Drawing.Size(1006, 379);
			this.grid_prod.TabIndex = 9;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.panel2.Controls.Add(this.txt_cantidad);
			this.panel2.Controls.Add(this.lbl_cantidad);
			this.panel2.Controls.Add(this.txt_precio);
			this.panel2.Controls.Add(this.lbl_precio);
			this.panel2.Controls.Add(this.btn_cargar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 379);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1006, 54);
			this.panel2.TabIndex = 10;
			// 
			// txt_cantidad
			// 
			this.txt_cantidad.Location = new System.Drawing.Point(265, 16);
			this.txt_cantidad.Name = "txt_cantidad";
			this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
			this.txt_cantidad.TabIndex = 14;
			// 
			// lbl_cantidad
			// 
			this.lbl_cantidad.Location = new System.Drawing.Point(187, 16);
			this.lbl_cantidad.Name = "lbl_cantidad";
			this.lbl_cantidad.Size = new System.Drawing.Size(100, 23);
			this.lbl_cantidad.TabIndex = 13;
			this.lbl_cantidad.Text = "CANTIDAD";
			// 
			// txt_precio
			// 
			this.txt_precio.Location = new System.Drawing.Point(724, 19);
			this.txt_precio.Name = "txt_precio";
			this.txt_precio.Size = new System.Drawing.Size(100, 20);
			this.txt_precio.TabIndex = 12;
			// 
			// lbl_precio
			// 
			this.lbl_precio.Location = new System.Drawing.Point(601, 19);
			this.lbl_precio.Name = "lbl_precio";
			this.lbl_precio.Size = new System.Drawing.Size(100, 23);
			this.lbl_precio.TabIndex = 11;
			this.lbl_precio.Text = "PRECIO";
			// 
			// btn_cargar
			// 
			this.btn_cargar.BackColor = System.Drawing.Color.Lime;
			this.btn_cargar.Location = new System.Drawing.Point(921, 19);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(75, 23);
			this.btn_cargar.TabIndex = 10;
			this.btn_cargar.Text = "CARGAR";
			this.btn_cargar.UseVisualStyleBackColor = false;
			this.btn_cargar.Click += new System.EventHandler(this.Btn_cargarClick);
			// 
			// Formproductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1006, 433);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.grid_prod);
			this.Controls.Add(this.panel1);
			this.Name = "Formproductos";
			this.Text = "Formproductos";
			this.Load += new System.EventHandler(this.FormproductosLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_prod)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
		}
	}

