/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 06/11/2023
 * Time: 20:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace login
{
	partial class Formingresar
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
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.lbl_apellido = new System.Windows.Forms.Label();
			this.lbl_dni = new System.Windows.Forms.Label();
			this.lbl_edad = new System.Windows.Forms.Label();
			this.lbl_email = new System.Windows.Forms.Label();
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.txt_apellido = new System.Windows.Forms.TextBox();
			this.txt_dni = new System.Windows.Forms.TextBox();
			this.txt_edad = new System.Windows.Forms.TextBox();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.btn_ingresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.Location = new System.Drawing.Point(108, 44);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(100, 23);
			this.lbl_nombre.TabIndex = 0;
			this.lbl_nombre.Text = "NOMBRE";
			// 
			// lbl_apellido
			// 
			this.lbl_apellido.Location = new System.Drawing.Point(108, 96);
			this.lbl_apellido.Name = "lbl_apellido";
			this.lbl_apellido.Size = new System.Drawing.Size(100, 23);
			this.lbl_apellido.TabIndex = 1;
			this.lbl_apellido.Text = "APELLIDO";
			// 
			// lbl_dni
			// 
			this.lbl_dni.Location = new System.Drawing.Point(108, 162);
			this.lbl_dni.Name = "lbl_dni";
			this.lbl_dni.Size = new System.Drawing.Size(100, 23);
			this.lbl_dni.TabIndex = 2;
			this.lbl_dni.Text = "DNI";
			// 
			// lbl_edad
			// 
			this.lbl_edad.Location = new System.Drawing.Point(108, 214);
			this.lbl_edad.Name = "lbl_edad";
			this.lbl_edad.Size = new System.Drawing.Size(100, 23);
			this.lbl_edad.TabIndex = 3;
			this.lbl_edad.Text = "EDAD";
			// 
			// lbl_email
			// 
			this.lbl_email.Location = new System.Drawing.Point(108, 268);
			this.lbl_email.Name = "lbl_email";
			this.lbl_email.Size = new System.Drawing.Size(100, 23);
			this.lbl_email.TabIndex = 4;
			this.lbl_email.Text = "EMAIL";
			// 
			// txt_nombre
			// 
			this.txt_nombre.Location = new System.Drawing.Point(330, 44);
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.Size = new System.Drawing.Size(100, 20);
			this.txt_nombre.TabIndex = 5;
			// 
			// txt_apellido
			// 
			this.txt_apellido.Location = new System.Drawing.Point(330, 96);
			this.txt_apellido.Name = "txt_apellido";
			this.txt_apellido.Size = new System.Drawing.Size(100, 20);
			this.txt_apellido.TabIndex = 6;
			// 
			// txt_dni
			// 
			this.txt_dni.Location = new System.Drawing.Point(330, 162);
			this.txt_dni.Name = "txt_dni";
			this.txt_dni.Size = new System.Drawing.Size(100, 20);
			this.txt_dni.TabIndex = 7;
			// 
			// txt_edad
			// 
			this.txt_edad.Location = new System.Drawing.Point(330, 214);
			this.txt_edad.Name = "txt_edad";
			this.txt_edad.Size = new System.Drawing.Size(100, 20);
			this.txt_edad.TabIndex = 8;
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(330, 268);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(100, 20);
			this.txt_email.TabIndex = 9;
			// 
			// btn_ingresar
			// 
			this.btn_ingresar.Location = new System.Drawing.Point(223, 335);
			this.btn_ingresar.Name = "btn_ingresar";
			this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
			this.btn_ingresar.TabIndex = 10;
			this.btn_ingresar.Text = "INGRESAR";
			this.btn_ingresar.UseVisualStyleBackColor = true;
			this.btn_ingresar.Click += new System.EventHandler(this.Btn_ingresarClick);
			// 
			// Formingresar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 468);
			this.Controls.Add(this.btn_ingresar);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.txt_edad);
			this.Controls.Add(this.txt_dni);
			this.Controls.Add(this.txt_apellido);
			this.Controls.Add(this.txt_nombre);
			this.Controls.Add(this.lbl_email);
			this.Controls.Add(this.lbl_edad);
			this.Controls.Add(this.lbl_dni);
			this.Controls.Add(this.lbl_apellido);
			this.Controls.Add(this.lbl_nombre);
			this.Name = "Formingresar";
			this.Text = "Formingresar";
			this.Load += new System.EventHandler(this.FormingresarLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_ingresar;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.TextBox txt_edad;
		private System.Windows.Forms.TextBox txt_dni;
		private System.Windows.Forms.TextBox txt_apellido;
		private System.Windows.Forms.TextBox txt_nombre;
		private System.Windows.Forms.Label lbl_email;
		private System.Windows.Forms.Label lbl_edad;
		private System.Windows.Forms.Label lbl_dni;
		private System.Windows.Forms.Label lbl_apellido;
		private System.Windows.Forms.Label lbl_nombre;
	}
}
