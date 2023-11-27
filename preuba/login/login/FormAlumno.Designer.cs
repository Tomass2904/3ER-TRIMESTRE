/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 30/10/2023
 * Time: 20:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace login
{
	partial class FormAlumno
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_eliminar = new System.Windows.Forms.Button();
			this.btn_modificar = new System.Windows.Forms.Button();
			this.btn_ingresar = new System.Windows.Forms.Button();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_eliminar);
			this.panel1.Controls.Add(this.btn_modificar);
			this.panel1.Controls.Add(this.btn_ingresar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(889, 50);
			this.panel1.TabIndex = 1;
			// 
			// btn_eliminar
			// 
			this.btn_eliminar.Location = new System.Drawing.Point(268, 12);
			this.btn_eliminar.Name = "btn_eliminar";
			this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
			this.btn_eliminar.TabIndex = 2;
			this.btn_eliminar.Text = "ELIMINAR";
			this.btn_eliminar.UseVisualStyleBackColor = true;
			this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminarClick);
			// 
			// btn_modificar
			// 
			this.btn_modificar.Location = new System.Drawing.Point(162, 12);
			this.btn_modificar.Name = "btn_modificar";
			this.btn_modificar.Size = new System.Drawing.Size(75, 23);
			this.btn_modificar.TabIndex = 1;
			this.btn_modificar.Text = "MODIFICAR";
			this.btn_modificar.UseVisualStyleBackColor = true;
			this.btn_modificar.Click += new System.EventHandler(this.Btn_modificarClick);
			// 
			// btn_ingresar
			// 
			this.btn_ingresar.Location = new System.Drawing.Point(47, 13);
			this.btn_ingresar.Name = "btn_ingresar";
			this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
			this.btn_ingresar.TabIndex = 0;
			this.btn_ingresar.Text = "INGRESAR";
			this.btn_ingresar.UseVisualStyleBackColor = true;
			this.btn_ingresar.Click += new System.EventHandler(this.Btn_ingresarClick);
			// 
			// gridDatos
			// 
			this.gridDatos.AllowUserToAddRows = false;
			this.gridDatos.AllowUserToDeleteRows = false;
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridDatos.Location = new System.Drawing.Point(0, 50);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.ReadOnly = true;
			this.gridDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridDatos.Size = new System.Drawing.Size(889, 440);
			this.gridDatos.TabIndex = 2;
			// 
			// FormAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 490);
			this.Controls.Add(this.gridDatos);
			this.Controls.Add(this.panel1);
			this.Name = "FormAlumno";
			this.Text = "FormAlumno";
			this.Load += new System.EventHandler(this.FormAlumnoLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView gridDatos;
		private System.Windows.Forms.Button btn_ingresar;
		private System.Windows.Forms.Button btn_modificar;
		private System.Windows.Forms.Button btn_eliminar;
		private System.Windows.Forms.Panel panel1;
	}
}
