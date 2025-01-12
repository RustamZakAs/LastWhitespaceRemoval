namespace LastWhitespaceRemoval
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbPath = new TextBox();
            btnOpenDialog = new Button();
            label1 = new Label();
            btnStart = new Button();
            textBox1 = new TextBox();
            lblFilters = new Label();
            pbFiles = new ProgressBar();
            SuspendLayout();
            // 
            // tbPath
            // 
            tbPath.Location = new Point(122, 17);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(378, 27);
            tbPath.TabIndex = 0;
            // 
            // btnOpenDialog
            // 
            btnOpenDialog.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenDialog.Location = new Point(499, 16);
            btnOpenDialog.Name = "btnOpenDialog";
            btnOpenDialog.Size = new Size(40, 29);
            btnOpenDialog.TabIndex = 1;
            btnOpenDialog.Text = "...";
            btnOpenDialog.UseVisualStyleBackColor = true;
            btnOpenDialog.Click += btnOpenDialog_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Location:";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(601, 15);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 27);
            textBox1.TabIndex = 4;
            // 
            // lblFilters
            // 
            lblFilters.AutoSize = true;
            lblFilters.Location = new Point(12, 53);
            lblFilters.Name = "lblFilters";
            lblFilters.Size = new Size(51, 20);
            lblFilters.TabIndex = 5;
            lblFilters.Text = "Filters:";
            // 
            // pbFiles
            // 
            pbFiles.Dock = DockStyle.Bottom;
            pbFiles.Location = new Point(0, 257);
            pbFiles.Name = "pbFiles";
            pbFiles.Size = new Size(716, 13);
            pbFiles.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 270);
            Controls.Add(pbFiles);
            Controls.Add(lblFilters);
            Controls.Add(textBox1);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Controls.Add(tbPath);
            Controls.Add(btnOpenDialog);
            Name = "FormMain";
            Text = "Last whitespace removal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPath;
        private Button btnOpenDialog;
        private Label label1;
        private Button btnStart;
        private TextBox textBox1;
        private Label lblFilters;
        private ProgressBar pbFiles;
    }
}
