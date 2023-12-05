﻿/*
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
			this.mesa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mesa_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mesa_capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mesa_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mesa_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_cargar_prod = new System.Windows.Forms.Button();
			this.btn_eliminar_prod = new System.Windows.Forms.Button();
			this.btn_eliminar_mesas = new System.Windows.Forms.Button();
			this.btn_cargar_mesas = new System.Windows.Forms.Button();
			this.grid_prod_mesas = new System.Windows.Forms.DataGridView();
			this.txt_total = new System.Windows.Forms.TextBox();
			this.lbl_total = new System.Windows.Forms.Label();
			this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridmesas)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_prod_mesas)).BeginInit();
			this.SuspendLayout();
			// 
			// gridmesas
			// 
			this.gridmesas.AllowUserToAddRows = false;
			this.gridmesas.AllowUserToDeleteRows = false;
			this.gridmesas.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gridmesas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.gridmesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridmesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.mesa_id,
			this.mesa_numero,
			this.mesa_capacidad,
			this.mesa_estado,
			this.mesa_descripcion});
			this.gridmesas.Location = new System.Drawing.Point(8, 106);
			this.gridmesas.Name = "gridmesas";
			this.gridmesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridmesas.Size = new System.Drawing.Size(629, 461);
			this.gridmesas.TabIndex = 3;
			this.gridmesas.SelectionChanged += new System.EventHandler(this.Gridmesas_SelectionChanged);
			// 
			// mesa_id
			// 
			this.mesa_id.DataPropertyName = "mesa_id";
			this.mesa_id.HeaderText = "#";
			this.mesa_id.Name = "mesa_id";
			// 
			// mesa_numero
			// 
			this.mesa_numero.DataPropertyName = "mesa_numero";
			this.mesa_numero.HeaderText = "MESA";
			this.mesa_numero.Name = "mesa_numero";
			// 
			// mesa_capacidad
			// 
			this.mesa_capacidad.DataPropertyName = "mesa_capacidad";
			this.mesa_capacidad.HeaderText = "CAPACIDAD";
			this.mesa_capacidad.Name = "mesa_capacidad";
			// 
			// mesa_estado
			// 
			this.mesa_estado.DataPropertyName = "mesa_estado";
			this.mesa_estado.HeaderText = "ESTADO";
			this.mesa_estado.Name = "mesa_estado";
			// 
			// mesa_descripcion
			// 
			this.mesa_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.mesa_descripcion.DataPropertyName = "mesa_descripcion";
			this.mesa_descripcion.HeaderText = "DESCRIPCION";
			this.mesa_descripcion.Name = "mesa_descripcion";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.btn_cargar_prod);
			this.panel1.Controls.Add(this.btn_eliminar_prod);
			this.panel1.Controls.Add(this.btn_eliminar_mesas);
			this.panel1.Controls.Add(this.btn_cargar_mesas);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1196, 100);
			this.panel1.TabIndex = 4;
			// 
			// btn_cargar_prod
			// 
			this.btn_cargar_prod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_cargar_prod.BackColor = System.Drawing.Color.Lime;
			this.btn_cargar_prod.Location = new System.Drawing.Point(914, 12);
			this.btn_cargar_prod.Name = "btn_cargar_prod";
			this.btn_cargar_prod.Size = new System.Drawing.Size(117, 69);
			this.btn_cargar_prod.TabIndex = 4;
			this.btn_cargar_prod.Text = "Cargar productos";
			this.btn_cargar_prod.UseVisualStyleBackColor = false;
			this.btn_cargar_prod.Visible = false;
			this.btn_cargar_prod.Click += new System.EventHandler(this.BtnCargarProductosClick);
			// 
			// btn_eliminar_prod
			// 
			this.btn_eliminar_prod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_eliminar_prod.BackColor = System.Drawing.Color.Red;
			this.btn_eliminar_prod.Location = new System.Drawing.Point(1060, 12);
			this.btn_eliminar_prod.Name = "btn_eliminar_prod";
			this.btn_eliminar_prod.Size = new System.Drawing.Size(117, 69);
			this.btn_eliminar_prod.TabIndex = 3;
			this.btn_eliminar_prod.Text = "Eliminar productos";
			this.btn_eliminar_prod.UseVisualStyleBackColor = false;
			this.btn_eliminar_prod.Click += new System.EventHandler(this.BtnEliminarProductosClick);
			// 
			// btn_eliminar_mesas
			// 
			this.btn_eliminar_mesas.BackColor = System.Drawing.Color.Red;
			this.btn_eliminar_mesas.Location = new System.Drawing.Point(146, 12);
			this.btn_eliminar_mesas.Name = "btn_eliminar_mesas";
			this.btn_eliminar_mesas.Size = new System.Drawing.Size(117, 69);
			this.btn_eliminar_mesas.TabIndex = 2;
			this.btn_eliminar_mesas.Text = "Eliminar mesas";
			this.btn_eliminar_mesas.UseVisualStyleBackColor = false;
			this.btn_eliminar_mesas.Click += new System.EventHandler(this.Btn_eliminar_mesasClick);
			// 
			// btn_cargar_mesas
			// 
			this.btn_cargar_mesas.BackColor = System.Drawing.Color.Lime;
			this.btn_cargar_mesas.Location = new System.Drawing.Point(12, 12);
			this.btn_cargar_mesas.Name = "btn_cargar_mesas";
			this.btn_cargar_mesas.Size = new System.Drawing.Size(117, 69);
			this.btn_cargar_mesas.TabIndex = 0;
			this.btn_cargar_mesas.Text = "Cargar mesas";
			this.btn_cargar_mesas.UseVisualStyleBackColor = false;
			this.btn_cargar_mesas.Click += new System.EventHandler(this.Btn_cargar_mesasClick);
			// 
			// grid_prod_mesas
			// 
			this.grid_prod_mesas.AllowUserToAddRows = false;
			this.grid_prod_mesas.AllowUserToDeleteRows = false;
			this.grid_prod_mesas.AllowUserToOrderColumns = true;
			this.grid_prod_mesas.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.grid_prod_mesas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.grid_prod_mesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.grid_prod_mesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column,
			this.colum,
			this.colum1,
			this.column12});
			this.grid_prod_mesas.GridColor = System.Drawing.Color.White;
			this.grid_prod_mesas.Location = new System.Drawing.Point(756, 106);
			this.grid_prod_mesas.Name = "grid_prod_mesas";
			this.grid_prod_mesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_prod_mesas.Size = new System.Drawing.Size(358, 461);
			this.grid_prod_mesas.TabIndex = 3;
			// 
			// txt_total
			// 
			this.txt_total.Location = new System.Drawing.Point(971, 592);
			this.txt_total.Name = "txt_total";
			this.txt_total.Size = new System.Drawing.Size(100, 20);
			this.txt_total.TabIndex = 5;
			// 
			// lbl_total
			// 
			this.lbl_total.Location = new System.Drawing.Point(791, 592);
			this.lbl_total.Name = "lbl_total";
			this.lbl_total.Size = new System.Drawing.Size(100, 23);
			this.lbl_total.TabIndex = 6;
			this.lbl_total.Text = "Total";
			// 
			// Column
			// 
			this.Column.DataPropertyName = "mepr_id";
			this.Column.HeaderText = "ID";
			this.Column.Name = "Column";
			// 
			// colum
			// 
			this.colum.DataPropertyName = "prod_nombre";
			this.colum.HeaderText = "NOMBRE";
			this.colum.Name = "colum";
			// 
			// colum1
			// 
			this.colum1.DataPropertyName = "mepr_precio";
			this.colum1.HeaderText = "PRECIO";
			this.colum1.Name = "colum1";
			// 
			// column12
			// 
			this.column12.DataPropertyName = "mepr_cantidad";
			this.column12.HeaderText = "CANTIDAD";
			this.column12.Name = "column12";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1225, 624);
			this.Controls.Add(this.lbl_total);
			this.Controls.Add(this.txt_total);
			this.Controls.Add(this.grid_prod_mesas);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gridmesas);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "resto";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.gridmesas)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid_prod_mesas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.DataGridView gridmesas;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_eliminar_mesas;
		private System.Windows.Forms.Button btn_cargar_mesas;
		private System.Windows.Forms.DataGridView grid_prod_mesas;
		private System.Windows.Forms.Button btn_cargar_prod;
		private System.Windows.Forms.Button btn_eliminar_prod;

		private System.Windows.Forms.DataGridViewTextBoxColumn mesa_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn mesa_numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn mesa_capacidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn mesa_estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn mesa_descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn colum;
		private System.Windows.Forms.DataGridViewTextBoxColumn colum1;
		private System.Windows.Forms.DataGridViewTextBoxColumn column12;
		private System.Windows.Forms.TextBox txt_total;
		private System.Windows.Forms.Label lbl_total;
	}
	
}





