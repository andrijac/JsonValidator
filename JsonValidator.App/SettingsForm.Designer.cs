namespace JsonValidator.App
{
    partial class SettingsForm
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
            this.cbJsonAllowTrailingCommas = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbJsonAllowComments = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbJsonAllowTrailingCommas
            // 
            this.cbJsonAllowTrailingCommas.AutoSize = true;
            this.cbJsonAllowTrailingCommas.Location = new System.Drawing.Point(6, 22);
            this.cbJsonAllowTrailingCommas.Name = "cbJsonAllowTrailingCommas";
            this.cbJsonAllowTrailingCommas.Size = new System.Drawing.Size(148, 19);
            this.cbJsonAllowTrailingCommas.TabIndex = 0;
            this.cbJsonAllowTrailingCommas.Text = "Allow Trailing Commas";
            this.cbJsonAllowTrailingCommas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbJsonAllowComments);
            this.groupBox1.Controls.Add(this.cbJsonAllowTrailingCommas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JSON validation";
            // 
            // cbJsonAllowComments
            // 
            this.cbJsonAllowComments.AutoSize = true;
            this.cbJsonAllowComments.Location = new System.Drawing.Point(6, 47);
            this.cbJsonAllowComments.Name = "cbJsonAllowComments";
            this.cbJsonAllowComments.Size = new System.Drawing.Size(118, 19);
            this.cbJsonAllowComments.TabIndex = 1;
            this.cbJsonAllowComments.Text = "Allow Comments";
            this.cbJsonAllowComments.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(56, 99);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(223, 134);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox cbJsonAllowTrailingCommas;
        private GroupBox groupBox1;
        private CheckBox cbJsonAllowComments;
        private Button btnCancel;
        private Button btnOk;
    }
}