namespace Will_Weibo_Tencent
{
    partial class FrmRequestSelect
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
            this.btnSettingForRequest = new System.Windows.Forms.Button();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnGoExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettingForRequest
            // 
            this.btnSettingForRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettingForRequest.Location = new System.Drawing.Point(262, 20);
            this.btnSettingForRequest.Name = "btnSettingForRequest";
            this.btnSettingForRequest.Size = new System.Drawing.Size(74, 20);
            this.btnSettingForRequest.TabIndex = 17;
            this.btnSettingForRequest.Text = "Setting";
            this.btnSettingForRequest.UseVisualStyleBackColor = true;
            this.btnSettingForRequest.Click += new System.EventHandler(this.btnSettingForRequest_Click);
            // 
            // comboBoxCondition
            // 
            this.comboBoxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Location = new System.Drawing.Point(19, 20);
            this.comboBoxCondition.Name = "comboBoxCondition";
            this.comboBoxCondition.Size = new System.Drawing.Size(228, 20);
            this.comboBoxCondition.TabIndex = 16;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(189, 58);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(96, 36);
            this.btnRequest.TabIndex = 19;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnGoExport
            // 
            this.btnGoExport.Location = new System.Drawing.Point(67, 58);
            this.btnGoExport.Name = "btnGoExport";
            this.btnGoExport.Size = new System.Drawing.Size(96, 36);
            this.btnGoExport.TabIndex = 20;
            this.btnGoExport.Text = "Goto Export";
            this.btnGoExport.UseVisualStyleBackColor = true;
            this.btnGoExport.Click += new System.EventHandler(this.btnGoExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCondition);
            this.groupBox1.Controls.Add(this.btnGoExport);
            this.groupBox1.Controls.Add(this.btnSettingForRequest);
            this.groupBox1.Controls.Add(this.btnRequest);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 105);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // FrmRequestSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(381, 131);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmRequestSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRequestSelect";
            this.Load += new System.EventHandler(this.FrmReadRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettingForRequest;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnGoExport;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}