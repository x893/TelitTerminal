namespace TelitTerminal
{
	partial class ButtonDefinition
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CmdUserText = new System.Windows.Forms.TextBox();
			this.btnCmdUserCancel = new TelitTerminal.XButton();
			this.btnCmdUserOK = new TelitTerminal.XButton();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CmdUserText
			// 
			this.CmdUserText.Location = new System.Drawing.Point(13, 47);
			this.CmdUserText.Margin = new System.Windows.Forms.Padding(4);
			this.CmdUserText.Name = "CmdUserText";
			this.CmdUserText.Size = new System.Drawing.Size(177, 22);
			this.CmdUserText.TabIndex = 46;
			// 
			// btnCmdUserCancel
			// 
			this.btnCmdUserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCmdUserCancel.Location = new System.Drawing.Point(268, 44);
			this.btnCmdUserCancel.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmdUserCancel.Name = "btnCmdUserCancel";
			this.btnCmdUserCancel.Size = new System.Drawing.Size(67, 28);
			this.btnCmdUserCancel.TabIndex = 48;
			this.btnCmdUserCancel.Text = "Cancel";
			this.btnCmdUserCancel.UseVisualStyleBackColor = true;
			// 
			// btnCmdUserOK
			// 
			this.btnCmdUserOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCmdUserOK.Location = new System.Drawing.Point(200, 44);
			this.btnCmdUserOK.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmdUserOK.Name = "btnCmdUserOK";
			this.btnCmdUserOK.Size = new System.Drawing.Size(60, 28);
			this.btnCmdUserOK.TabIndex = 47;
			this.btnCmdUserOK.Text = "Save";
			this.btnCmdUserOK.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label6.Location = new System.Drawing.Point(10, 9);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(217, 26);
			this.label6.TabIndex = 49;
			this.label6.Text = "Enter command for button";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ButtonDefinition
			// 
			this.AcceptButton = this.btnCmdUserOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCmdUserCancel;
			this.ClientSize = new System.Drawing.Size(348, 107);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.CmdUserText);
			this.Controls.Add(this.btnCmdUserCancel);
			this.Controls.Add(this.btnCmdUserOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ButtonDefinition";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Define Button";
			this.Shown += new System.EventHandler(this.ButtonDefinition_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox CmdUserText;
		private XButton btnCmdUserCancel;
		private XButton btnCmdUserOK;
		private System.Windows.Forms.Label label6;
	}
}