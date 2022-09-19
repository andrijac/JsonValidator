namespace JsonValidator.App
{
    partial class MainForm
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
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPaste = new System.Windows.Forms.Button();
            this.txtClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtJson = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(3, 3);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "V&alidate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.BtnValidateClick);
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutput.Location = new System.Drawing.Point(0, 428);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(288, 257);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnValidate);
            this.flowLayoutPanel1.Controls.Add(this.txtPaste);
            this.flowLayoutPanel1.Controls.Add(this.txtClear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(708, 28);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // txtPaste
            // 
            this.txtPaste.Location = new System.Drawing.Point(84, 3);
            this.txtPaste.Name = "txtPaste";
            this.txtPaste.Size = new System.Drawing.Size(75, 23);
            this.txtPaste.TabIndex = 3;
            this.txtPaste.Text = "Paste";
            this.txtPaste.UseVisualStyleBackColor = true;
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(165, 3);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(75, 23);
            this.txtClear.TabIndex = 4;
            this.txtClear.Text = "Clear";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtJson);
            this.panel1.Controls.Add(this.txtOutput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 685);
            this.panel1.TabIndex = 7;
            // 
            // txtJson
            // 
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.Location = new System.Drawing.Point(0, 0);
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(288, 428);
            this.txtJson.TabIndex = 5;
            this.txtJson.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtxtResult);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(288, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 685);
            this.panel2.TabIndex = 9;
            // 
            // rtxtResult
            // 
            this.rtxtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtResult.Location = new System.Drawing.Point(0, 20);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.ReadOnly = true;
            this.rtxtResult.Size = new System.Drawing.Size(420, 665);
            this.rtxtResult.TabIndex = 10;
            this.rtxtResult.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 20);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 713);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnValidate;
        private TextBox txtOutput;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button txtPaste;
        private Button txtClear;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private RichTextBox rtxtResult;
        private RichTextBox txtJson;
    }
}