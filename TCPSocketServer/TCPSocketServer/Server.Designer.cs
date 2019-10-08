/*
 * Created by SharpDevelop.
 * User: Crogogo
 * Date: 10/6/2019
 * Time: 10:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TCPSocketServer
{
	partial class Server
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnStartServer;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		
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
			this.btnStartServer = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnStartServer
			// 
			this.btnStartServer.Location = new System.Drawing.Point(12, 238);
			this.btnStartServer.Name = "btnStartServer";
			this.btnStartServer.Size = new System.Drawing.Size(75, 23);
			this.btnStartServer.TabIndex = 0;
			this.btnStartServer.Text = "Start Server";
			this.btnStartServer.UseVisualStyleBackColor = true;
			this.btnStartServer.Click += new System.EventHandler(this.BtnStartServerClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(93, 238);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(268, 220);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// Server
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnStartServer);
			this.Name = "Server";
			this.Text = "Server";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
