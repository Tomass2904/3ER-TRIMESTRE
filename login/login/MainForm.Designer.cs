/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 09/10/2023
 * Time: 20:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace login
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
			this.txt_usu = new System.Windows.Forms.TextBox();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.lbl_usuario = new System.Windows.Forms.Label();
			this.lbl_pass = new System.Windows.Forms.Label();
			this.btn_login = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_usu
			// 
			this.txt_usu.Location = new System.Drawing.Point(274, 90);
			this.txt_usu.Name = "txt_usu";
			this.txt_usu.Size = new System.Drawing.Size(100, 20);
			this.txt_usu.TabIndex = 0;
			// 
			// txt_pass
			// 
			this.txt_pass.Location = new System.Drawing.Point(274, 146);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.PasswordChar = '*';
			this.txt_pass.Size = new System.Drawing.Size(100, 20);
			this.txt_pass.TabIndex = 1;
			// 
			// lbl_usuario
			// 
			this.lbl_usuario.Location = new System.Drawing.Point(95, 90);
			this.lbl_usuario.Name = "lbl_usuario";
			this.lbl_usuario.Size = new System.Drawing.Size(100, 23);
			this.lbl_usuario.TabIndex = 2;
			this.lbl_usuario.Text = "Usuario";
			// 
			// lbl_pass
			// 
			this.lbl_pass.Location = new System.Drawing.Point(95, 149);
			this.lbl_pass.Name = "lbl_pass";
			this.lbl_pass.Size = new System.Drawing.Size(100, 23);
			this.lbl_pass.TabIndex = 3;
			this.lbl_pass.Text = "Password";
			// 
			// btn_login
			// 
			this.btn_login.Location = new System.Drawing.Point(190, 226);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(75, 23);
			this.btn_login.TabIndex = 4;
			this.btn_login.Text = "LOGIN";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.Btn_loginClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(298, 274);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 349);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_login);
			this.Controls.Add(this.lbl_pass);
			this.Controls.Add(this.lbl_usuario);
			this.Controls.Add(this.txt_pass);
			this.Controls.Add(this.txt_usu);
			this.Name = "MainForm";
			this.Text = "login";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.Label lbl_pass;
		private System.Windows.Forms.Label lbl_usuario;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.TextBox txt_usu;
	}
}
