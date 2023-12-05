/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 07/11/2023
 * Time: 8:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace resto
{
	partial class FormCARGAR
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
			this.lbl_numero = new System.Windows.Forms.Label();
			this.lbl_capacidad = new System.Windows.Forms.Label();
			this.lbl_estado = new System.Windows.Forms.Label();
			this.txt_numero = new System.Windows.Forms.TextBox();
			this.txt_capacidad = new System.Windows.Forms.TextBox();
			this.txt_estado = new System.Windows.Forms.TextBox();
			this.btn_cargar = new System.Windows.Forms.Button();
			this.lbl_descripcion = new System.Windows.Forms.Label();
			this.txt_descripcion = new System.Windows.Forms.TextBox();
			this.btn_cerrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_numero
			// 
			this.lbl_numero.Location = new System.Drawing.Point(58, 40);
			this.lbl_numero.Name = "lbl_numero";
			this.lbl_numero.Size = new System.Drawing.Size(100, 23);
			this.lbl_numero.TabIndex = 0;
			this.lbl_numero.Text = "NUMERO";
			// 
			// lbl_capacidad
			// 
			this.lbl_capacidad.Location = new System.Drawing.Point(58, 90);
			this.lbl_capacidad.Name = "lbl_capacidad";
			this.lbl_capacidad.Size = new System.Drawing.Size(100, 23);
			this.lbl_capacidad.TabIndex = 1;
			this.lbl_capacidad.Text = "CAPACIDAD";
			// 
			// lbl_estado
			// 
			this.lbl_estado.Location = new System.Drawing.Point(58, 134);
			this.lbl_estado.Name = "lbl_estado";
			this.lbl_estado.Size = new System.Drawing.Size(100, 23);
			this.lbl_estado.TabIndex = 2;
			this.lbl_estado.Text = "ESTADO";
			// 
			// txt_numero
			// 
			this.txt_numero.Location = new System.Drawing.Point(164, 40);
			this.txt_numero.Name = "txt_numero";
			this.txt_numero.Size = new System.Drawing.Size(100, 20);
			this.txt_numero.TabIndex = 3;
			// 
			// txt_capacidad
			// 
			this.txt_capacidad.Location = new System.Drawing.Point(164, 93);
			this.txt_capacidad.Name = "txt_capacidad";
			this.txt_capacidad.Size = new System.Drawing.Size(100, 20);
			this.txt_capacidad.TabIndex = 4;
			// 
			// txt_estado
			// 
			this.txt_estado.Location = new System.Drawing.Point(164, 134);
			this.txt_estado.Name = "txt_estado";
			this.txt_estado.Size = new System.Drawing.Size(100, 20);
			this.txt_estado.TabIndex = 5;
			// 
			// btn_cargar
			// 
			this.btn_cargar.Location = new System.Drawing.Point(111, 236);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(75, 23);
			this.btn_cargar.TabIndex = 6;
			this.btn_cargar.Text = "CARGAR";
			this.btn_cargar.UseVisualStyleBackColor = true;
			this.btn_cargar.Click += new System.EventHandler(this.Btn_cargarClick);
			// 
			// lbl_descripcion
			// 
			this.lbl_descripcion.Location = new System.Drawing.Point(58, 178);
			this.lbl_descripcion.Name = "lbl_descripcion";
			this.lbl_descripcion.Size = new System.Drawing.Size(100, 23);
			this.lbl_descripcion.TabIndex = 7;
			this.lbl_descripcion.Text = "DESCRIPCION";
			// 
			// txt_descripcion
			// 
			this.txt_descripcion.Location = new System.Drawing.Point(164, 178);
			this.txt_descripcion.Name = "txt_descripcion";
			this.txt_descripcion.Size = new System.Drawing.Size(100, 20);
			this.txt_descripcion.TabIndex = 8;
			// 
			// btn_cerrar
			// 
			this.btn_cerrar.Location = new System.Drawing.Point(232, 236);
			this.btn_cerrar.Name = "btn_cerrar";
			this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_cerrar.TabIndex = 9;
			this.btn_cerrar.Text = "CERRAR";
			this.btn_cerrar.UseVisualStyleBackColor = true;
			// 
			// FormCARGAR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(331, 306);
			this.Controls.Add(this.btn_cerrar);
			this.Controls.Add(this.txt_descripcion);
			this.Controls.Add(this.lbl_descripcion);
			this.Controls.Add(this.btn_cargar);
			this.Controls.Add(this.txt_estado);
			this.Controls.Add(this.txt_capacidad);
			this.Controls.Add(this.txt_numero);
			this.Controls.Add(this.lbl_estado);
			this.Controls.Add(this.lbl_capacidad);
			this.Controls.Add(this.lbl_numero);
			this.Name = "FormCARGAR";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormCARGAR";
			this.Load += new System.EventHandler(this.FormCARGARLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btn_cargar;
		private System.Windows.Forms.TextBox txt_estado;
		private System.Windows.Forms.TextBox txt_capacidad;
		private System.Windows.Forms.TextBox txt_numero;
		private System.Windows.Forms.Label lbl_estado;
		private System.Windows.Forms.Label lbl_capacidad;
		private System.Windows.Forms.Label lbl_numero;
		private System.Windows.Forms.Label lbl_descripcion;
		private System.Windows.Forms.TextBox txt_descripcion;
		private System.Windows.Forms.Button btn_cerrar;
	}
}
