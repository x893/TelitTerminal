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
			this.btnCmdUserCancel = new TelitTerminal.XButton();
			this.btnCmdUserOK = new TelitTerminal.XButton();
			this.CmdUserCommand = new System.Windows.Forms.TextBox();
			this.CmdUserTemplate = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CmdUserToolTip = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CmdUserText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCmdUserCancel
			// 
			this.btnCmdUserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCmdUserCancel.Location = new System.Drawing.Point(199, 116);
			this.btnCmdUserCancel.Name = "btnCmdUserCancel";
			this.btnCmdUserCancel.Size = new System.Drawing.Size(50, 23);
			this.btnCmdUserCancel.TabIndex = 4;
			this.btnCmdUserCancel.Text = "Cancel";
			this.btnCmdUserCancel.UseVisualStyleBackColor = true;
			// 
			// btnCmdUserOK
			// 
			this.btnCmdUserOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCmdUserOK.Location = new System.Drawing.Point(145, 116);
			this.btnCmdUserOK.Name = "btnCmdUserOK";
			this.btnCmdUserOK.Size = new System.Drawing.Size(45, 23);
			this.btnCmdUserOK.TabIndex = 3;
			this.btnCmdUserOK.Text = "Save";
			this.btnCmdUserOK.UseVisualStyleBackColor = true;
			// 
			// CmdUserCommand
			// 
			this.CmdUserCommand.Location = new System.Drawing.Point(74, 33);
			this.CmdUserCommand.Name = "CmdUserCommand";
			this.CmdUserCommand.Size = new System.Drawing.Size(175, 20);
			this.CmdUserCommand.TabIndex = 0;
			// 
			// CmdUserTemplate
			// 
			this.CmdUserTemplate.Location = new System.Drawing.Point(74, 59);
			this.CmdUserTemplate.Name = "CmdUserTemplate";
			this.CmdUserTemplate.Size = new System.Drawing.Size(175, 20);
			this.CmdUserTemplate.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 21);
			this.label1.TabIndex = 52;
			this.label1.Text = "Command";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(8, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 21);
			this.label2.TabIndex = 53;
			this.label2.Text = "Template";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CmdUserToolTip
			// 
			this.CmdUserToolTip.Location = new System.Drawing.Point(74, 85);
			this.CmdUserToolTip.Name = "CmdUserToolTip";
			this.CmdUserToolTip.Size = new System.Drawing.Size(175, 20);
			this.CmdUserToolTip.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label3.Location = new System.Drawing.Point(8, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 21);
			this.label3.TabIndex = 55;
			this.label3.Text = "Tooltip";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CmdUserText
			// 
			this.CmdUserText.Location = new System.Drawing.Point(74, 7);
			this.CmdUserText.Name = "CmdUserText";
			this.CmdUserText.Size = new System.Drawing.Size(175, 20);
			this.CmdUserText.TabIndex = 56;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label4.Location = new System.Drawing.Point(8, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 21);
			this.label4.TabIndex = 57;
			this.label4.Text = "Text";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ButtonDefinition
			// 
			this.AcceptButton = this.btnCmdUserOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCmdUserCancel;
			this.ClientSize = new System.Drawing.Size(261, 151);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.CmdUserText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CmdUserToolTip);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CmdUserTemplate);
			this.Controls.Add(this.CmdUserCommand);
			this.Controls.Add(this.btnCmdUserCancel);
			this.Controls.Add(this.btnCmdUserOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2);
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

		private XButton btnCmdUserCancel;
		private XButton btnCmdUserOK;
		private System.Windows.Forms.TextBox CmdUserCommand;
		private System.Windows.Forms.TextBox CmdUserTemplate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CmdUserToolTip;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox CmdUserText;
		private System.Windows.Forms.Label label4;
	}
}