namespace EY_CAA
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFileOrPathName = new System.Windows.Forms.TextBox();
            this.lblFileOrPathName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_MultipleFiles = new System.Windows.Forms.CheckBox();
            this.lblMultipleFiles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(644, 24);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFileOrPathName
            // 
            this.txtFileOrPathName.Location = new System.Drawing.Point(156, 27);
            this.txtFileOrPathName.Name = "txtFileOrPathName";
            this.txtFileOrPathName.Size = new System.Drawing.Size(456, 20);
            this.txtFileOrPathName.TabIndex = 1;
            this.txtFileOrPathName.Text = "File Name or Path Name";
            // 
            // lblFileOrPathName
            // 
            this.lblFileOrPathName.AutoSize = true;
            this.lblFileOrPathName.Location = new System.Drawing.Point(44, 33);
            this.lblFileOrPathName.Name = "lblFileOrPathName";
            this.lblFileOrPathName.Size = new System.Drawing.Size(82, 13);
            this.lblFileOrPathName.TabIndex = 2;
            this.lblFileOrPathName.Text = "File/Folder Path";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Sno,
            this.Column_FilePath,
            this.column_Status});
            this.dataGridView1.Location = new System.Drawing.Point(47, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 317);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column_Sno
            // 
            this.Column_Sno.HeaderText = "Sno";
            this.Column_Sno.Name = "Column_Sno";
            // 
            // Column_FilePath
            // 
            this.Column_FilePath.HeaderText = "FilePath";
            this.Column_FilePath.Name = "Column_FilePath";
            // 
            // column_Status
            // 
            this.column_Status.HeaderText = "Status";
            this.column_Status.Name = "column_Status";
            // 
            // check_MultipleFiles
            // 
            this.check_MultipleFiles.AutoSize = true;
            this.check_MultipleFiles.Location = new System.Drawing.Point(156, 69);
            this.check_MultipleFiles.Name = "check_MultipleFiles";
            this.check_MultipleFiles.Size = new System.Drawing.Size(44, 17);
            this.check_MultipleFiles.TabIndex = 4;
            this.check_MultipleFiles.Text = "Yes";
            this.check_MultipleFiles.UseVisualStyleBackColor = true;
            // 
            // lblMultipleFiles
            // 
            this.lblMultipleFiles.AutoSize = true;
            this.lblMultipleFiles.Location = new System.Drawing.Point(44, 73);
            this.lblMultipleFiles.Name = "lblMultipleFiles";
            this.lblMultipleFiles.Size = new System.Drawing.Size(67, 13);
            this.lblMultipleFiles.TabIndex = 5;
            this.lblMultipleFiles.Text = "Mitiple Files?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 496);
            this.Controls.Add(this.lblMultipleFiles);
            this.Controls.Add(this.check_MultipleFiles);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFileOrPathName);
            this.Controls.Add(this.txtFileOrPathName);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFileOrPathName;
        private System.Windows.Forms.Label lblFileOrPathName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Status;
        private System.Windows.Forms.CheckBox check_MultipleFiles;
        private System.Windows.Forms.Label lblMultipleFiles;
    }
}

