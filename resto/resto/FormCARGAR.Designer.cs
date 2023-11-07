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
			this.lbl_codigo = new System.Windows.Forms.Label();
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.lbl_precio = new System.Windows.Forms.Label();
			this.txt_codigo = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.btn_ingresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_codigo
			// 
			this.lbl_codigo.Location = new System.Drawing.Point(31, 51);
			this.lbl_codigo.Name = "lbl_codigo";
			this.lbl_codigo.Size = new System.Drawing.Size(100, 23);
			this.lbl_codigo.TabIndex = 0;
			this.lbl_codigo.Text = "CODIGO";

			// 
			// lbl_nombre
			// 
			this.lbl_nombre.Location = new System.Drawing.Point(31, 122);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(100, 23);
			this.lbl_nombre.TabIndex = 1;
			this.lbl_nombre.Text = "NOMBRE";
			// 
			// lbl_precio
			// 
			this.lbl_precio.Location = new System.Drawing.Point(31, 192);
			this.lbl_precio.Name = "lbl_precio";
			this.lbl_precio.Size = new System.Drawing.Size(100, 23);
			this.lbl_precio.TabIndex = 2;
			this.lbl_precio.Text = "PRECIO";
			// 
			// txt_codigo
			// 
			this.txt_codigo.Location = new System.Drawing.Point(137, 51);
			this.txt_codigo.Name = "txt_codigo";
			this.txt_codigo.Size = new System.Drawing.Size(100, 20);
			this.txt_codigo.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(137, 122);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(137, 192);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 5;
			// 
			// btn_ingresar
			// 
			this.btn_ingresar.Location = new System.Drawing.Point(73, 256);
			this.btn_ingresar.Name = "btn_ingresar";
			this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
			this.btn_ingresar.TabIndex = 6;
			this.btn_ingresar.Text = "INGRESAR";
			this.btn_ingresar.UseVisualStyleBackColor = true;
			// 
			// FormCARGAR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 562);
			this.Controls.Add(this.btn_ingresar);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.txt_codigo);
			this.Controls.Add(this.lbl_precio);
			this.Controls.Add(this.lbl_nombre);
			this.Controls.Add(this.lbl_codigo);
			this.Name = "FormCARGAR";
			this.Text = "FormCARGAR";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_ingresar;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox txt_codigo;
		private System.Windows.Forms.Label lbl_precio;
		private System.Windows.Forms.Label lbl_nombre;
		private System.Windows.Forms.Label lbl_codigo;
	}
}
