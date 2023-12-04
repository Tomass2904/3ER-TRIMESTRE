/*
 * Created by SharpDevelop.
 * User: TOMAS
 * Date: 03/12/2023
 * Time: 21:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace resto
{
	partial class Formlogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_usuario;
		private System.Windows.Forms.Label lbl_pass;
		private System.Windows.Forms.TextBox txt_usu;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.Button btn_entrar;
		
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
			this.lbl_usuario = new System.Windows.Forms.Label();
			this.lbl_pass = new System.Windows.Forms.Label();
			this.txt_usu = new System.Windows.Forms.TextBox();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.btn_entrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_usuario
			// 
			this.lbl_usuario.Location = new System.Drawing.Point(45, 56);
			this.lbl_usuario.Name = "lbl_usuario";
			this.lbl_usuario.Size = new System.Drawing.Size(100, 23);
			this.lbl_usuario.TabIndex = 0;
			this.lbl_usuario.Text = "USUARIO";
			// 
			// lbl_pass
			// 
			this.lbl_pass.Location = new System.Drawing.Point(45, 138);
			this.lbl_pass.Name = "lbl_pass";
			this.lbl_pass.Size = new System.Drawing.Size(100, 23);
			this.lbl_pass.TabIndex = 1;
			this.lbl_pass.Text = "PASSWORD";
			// 
			// txt_usu
			// 
			this.txt_usu.Location = new System.Drawing.Point(221, 56);
			this.txt_usu.Name = "txt_usu";
			this.txt_usu.Size = new System.Drawing.Size(100, 20);
			this.txt_usu.TabIndex = 2;
			// 
			// txt_pass
			// 
			this.txt_pass.Location = new System.Drawing.Point(221, 138);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.Size = new System.Drawing.Size(100, 20);
			this.txt_pass.TabIndex = 3;
			// 
			// btn_entrar
			// 
			this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btn_entrar.Location = new System.Drawing.Point(144, 206);
			this.btn_entrar.Name = "btn_entrar";
			this.btn_entrar.Size = new System.Drawing.Size(75, 23);
			this.btn_entrar.TabIndex = 4;
			this.btn_entrar.Text = "ENTRAR";
			this.btn_entrar.UseVisualStyleBackColor = false;
			this.btn_entrar.Click += new System.EventHandler(this.Btn_loginClick);
			// 
			// Formlogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(398, 301);
			this.Controls.Add(this.btn_entrar);
			this.Controls.Add(this.txt_pass);
			this.Controls.Add(this.txt_usu);
			this.Controls.Add(this.lbl_pass);
			this.Controls.Add(this.lbl_usuario);
			this.Name = "Formlogin";
			this.Text = "Formlogin";
			this.Load += new System.EventHandler(this.FormloginLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
