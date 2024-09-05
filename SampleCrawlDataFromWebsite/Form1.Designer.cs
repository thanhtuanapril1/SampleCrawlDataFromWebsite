namespace SampleCrawlDataFromWebsite
{
    partial class Form1
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
            tbxUrl = new TextBox();
            btnCrawl = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnClear = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tbxUrl
            // 
            tbxUrl.Location = new Point(13, 22);
            tbxUrl.Name = "tbxUrl";
            tbxUrl.Size = new Size(510, 23);
            tbxUrl.TabIndex = 0;
            tbxUrl.Text = "https://www.thegioididong.com/dtdd#c=42&o=17&pi=1";
            // 
            // btnCrawl
            // 
            btnCrawl.Location = new Point(538, 22);
            btnCrawl.Name = "btnCrawl";
            btnCrawl.Size = new Size(63, 23);
            btnCrawl.TabIndex = 1;
            btnCrawl.Text = "Crawl";
            btnCrawl.UseVisualStyleBackColor = true;
            btnCrawl.Click += btnCrawl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 4);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 2;
            label1.Text = "Url";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1289, 509);
            dataGridView1.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(617, 21);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(63, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(13, 48);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 595);
            Controls.Add(lblStatus);
            Controls.Add(btnClear);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnCrawl);
            Controls.Add(tbxUrl);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUrl;
        private Button btnCrawl;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnClear;
        private Label lblStatus;
    }
}
