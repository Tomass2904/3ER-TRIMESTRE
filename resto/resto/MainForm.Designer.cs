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
			this.btn_mesa1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_mesa1
			// 
			this.btn_mesa1.Location = new System.Drawing.Point(12, 12);
			this.btn_mesa1.Name = "btn_mesa1";
			this.btn_mesa1.Size = new System.Drawing.Size(69, 49);
			this.btn_mesa1.TabIndex = 0;
			this.btn_mesa1.Text = "MESA 1";
			this.btn_mesa1.UseVisualStyleBackColor = true;
			this.btn_mesa1.Click += new System.EventHandler(this.Btn_mesa1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1392, 624);
			this.Controls.Add(this.btn_mesa1);
			this.Name = "MainForm";
			this.Text = "resto";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_mesa1;
	}
}
