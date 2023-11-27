/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 07/11/2023
 * Time: 8:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace resto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.gridmesas = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_cargar_prod = new System.Windows.Forms.Button();
			this.btn_eliminar_prod = new System.Windows.Forms.Button();
			this.btn_eliminar_mesas = new System.Windows.Forms.Button();
			this.btn_cargar_mesas = new System.Windows.Forms.Button();
			this.grid_prod_mesas = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridmesas)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_prod_mesas)).BeginInit();
			this.SuspendLayout();
			// 
			// gridmesas
			// 
			this.gridmesas.AllowUserToAddRows = false;
			this.gridmesas.AllowUserToDeleteRows = false;
			this.gridmesas.AllowUserToOrderColumns = true;
			this.gridmesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridmesas.Location = new System.Drawing.Point(0, 106);
			this.gridmesas.Name = "gridmesas";
			this.gridmesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridmesas.Size = new System.Drawing.Size(686, 527);
			this.gridmesas.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_cargar_prod);
			this.panel1.Controls.Add(this.btn_eliminar_prod);
			this.panel1.Controls.Add(this.btn_eliminar_mesas);
			this.panel1.Controls.Add(this.btn_cargar_mesas);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1392, 100);
			this.panel1.TabIndex = 4;
			// 
			// btn_cargar_prod
			// 
			this.btn_cargar_prod.Location = new System.Drawing.Point(1130, 12);
			this.btn_cargar_prod.Name = "btn_cargar_prod";
			this.btn_cargar_prod.Size = new System.Drawing.Size(117, 69);
			this.btn_cargar_prod.TabIndex = 4;
			this.btn_cargar_prod.Text = "Cargar productos";
			this.btn_cargar_prod.UseVisualStyleBackColor = true;
			this.btn_cargar_prod.Visible = false;
			this.btn_cargar_prod.Click += new System.EventHandler(this.mesas_click);
			// 
			// btn_eliminar_prod
			// 
			this.btn_eliminar_prod.Location = new System.Drawing.Point(1263, 12);
			this.btn_eliminar_prod.Name = "btn_eliminar_prod";
			this.btn_eliminar_prod.Size = new System.Drawing.Size(117, 69);
			this.btn_eliminar_prod.TabIndex = 3;
			this.btn_eliminar_prod.Text = "Eliminar productos";
			this.btn_eliminar_prod.UseVisualStyleBackColor = true;
			// 
			// btn_eliminar_mesas
			// 
			this.btn_eliminar_mesas.Location = new System.Drawing.Point(146, 12);
			this.btn_eliminar_mesas.Name = "btn_eliminar_mesas";
			this.btn_eliminar_mesas.Size = new System.Drawing.Size(117, 69);
			this.btn_eliminar_mesas.TabIndex = 2;
			this.btn_eliminar_mesas.Text = "Eliminar mesas";
			this.btn_eliminar_mesas.UseVisualStyleBackColor = true;
			this.btn_eliminar_mesas.Click += new System.EventHandler(this.Btn_eliminar_mesasClick);
			// 
			// btn_cargar_mesas
			// 
			this.btn_cargar_mesas.Location = new System.Drawing.Point(12, 12);
			this.btn_cargar_mesas.Name = "btn_cargar_mesas";
			this.btn_cargar_mesas.Size = new System.Drawing.Size(117, 69);
			this.btn_cargar_mesas.TabIndex = 0;
			this.btn_cargar_mesas.Text = "Cargar mesas";
			this.btn_cargar_mesas.UseVisualStyleBackColor = true;
			this.btn_cargar_mesas.Click += new System.EventHandler(this.Btn_cargar_mesasClick);
			// 
			// grid_prod_mesas
			// 
			this.grid_prod_mesas.AllowUserToAddRows = false;
			this.grid_prod_mesas.AllowUserToDeleteRows = false;
			this.grid_prod_mesas.AllowUserToOrderColumns = true;
			this.grid_prod_mesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.grid_prod_mesas.Location = new System.Drawing.Point(682, 106);
			this.grid_prod_mesas.Name = "grid_prod_mesas";
			this.grid_prod_mesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_prod_mesas.Size = new System.Drawing.Size(710, 527);
			this.grid_prod_mesas.TabIndex = 3;
			this.grid_prod_mesas.Click += new System.EventHandler(this.prod_cargados);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1392, 624);
			this.Controls.Add(this.grid_prod_mesas);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gridmesas);
			this.Name = "MainForm";
			this.Text = "resto";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.gridmesas)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid_prod_mesas)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.DataGridView gridmesas;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_eliminar_mesas;
		private System.Windows.Forms.Button btn_cargar_mesas;
		private System.Windows.Forms.DataGridView grid_prod_mesas;
		private System.Windows.Forms.Button btn_cargar_prod;
		private System.Windows.Forms.Button btn_eliminar_prod;
		}
	
	
		
	}

