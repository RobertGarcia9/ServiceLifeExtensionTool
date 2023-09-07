namespace ServiceLifeExtensionTool
{
    partial class FormServiceLifeExtensionTool
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
            this.labelStartFolder = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPlannedExtension = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSetDueDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExtensionApplied = new System.Windows.Forms.TextBox();
            this.textBoxCurrentDate = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStartFolder
            // 
            this.labelStartFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStartFolder.AutoSize = true;
            this.labelStartFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartFolder.Location = new System.Drawing.Point(3, 331);
            this.labelStartFolder.Margin = new System.Windows.Forms.Padding(3);
            this.labelStartFolder.Name = "labelStartFolder";
            this.labelStartFolder.Size = new System.Drawing.Size(259, 24);
            this.labelStartFolder.TabIndex = 3;
            this.labelStartFolder.Text = "Current Service Due Date: ";
            this.labelStartFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelTitle, 2);
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1018, 190);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Service Life Extension Tool";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.89844F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.10156F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxPlannedExtension, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonExit, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonSetDueDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelStartFolder, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxExtensionApplied, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCurrentDate, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.16667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxPlannedExtension
            // 
            this.textBoxPlannedExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlannedExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlannedExtension.Location = new System.Drawing.Point(473, 430);
            this.textBoxPlannedExtension.Name = "textBoxPlannedExtension";
            this.textBoxPlannedExtension.ReadOnly = true;
            this.textBoxPlannedExtension.Size = new System.Drawing.Size(548, 29);
            this.textBoxPlannedExtension.TabIndex = 12;
            this.textBoxPlannedExtension.Text = "12 month extension YYYY/MM/DD";
            this.textBoxPlannedExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(3, 499);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(464, 98);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSetDueDate
            // 
            this.buttonSetDueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetDueDate.Location = new System.Drawing.Point(473, 499);
            this.buttonSetDueDate.Name = "buttonSetDueDate";
            this.buttonSetDueDate.Size = new System.Drawing.Size(548, 98);
            this.buttonSetDueDate.TabIndex = 8;
            this.buttonSetDueDate.Text = "Set Extended Due Date";
            this.buttonSetDueDate.UseVisualStyleBackColor = true;
            this.buttonSetDueDate.Click += new System.EventHandler(this.buttonSetDueDate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Service Life extension applied? ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extended Service Due Date: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxExtensionApplied
            // 
            this.textBoxExtensionApplied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtensionApplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExtensionApplied.Location = new System.Drawing.Point(473, 226);
            this.textBoxExtensionApplied.Name = "textBoxExtensionApplied";
            this.textBoxExtensionApplied.ReadOnly = true;
            this.textBoxExtensionApplied.Size = new System.Drawing.Size(548, 29);
            this.textBoxExtensionApplied.TabIndex = 10;
            this.textBoxExtensionApplied.Text = "No record of extention found";
            this.textBoxExtensionApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurrentDate
            // 
            this.textBoxCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentDate.Location = new System.Drawing.Point(473, 328);
            this.textBoxCurrentDate.Name = "textBoxCurrentDate";
            this.textBoxCurrentDate.ReadOnly = true;
            this.textBoxCurrentDate.Size = new System.Drawing.Size(548, 29);
            this.textBoxCurrentDate.TabIndex = 11;
            this.textBoxCurrentDate.Text = "Currently set YYYY/MM/DD";
            this.textBoxCurrentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormServiceLifeExtensionTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormServiceLifeExtensionTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Life Extension Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormServiceLifeExtensionTool_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStartFolder;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSetDueDate;
        private System.Windows.Forms.TextBox textBoxExtensionApplied;
        private System.Windows.Forms.TextBox textBoxPlannedExtension;
        private System.Windows.Forms.TextBox textBoxCurrentDate;
    }
}

