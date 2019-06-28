namespace RecurringQuery
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCommand = new System.Windows.Forms.TabPage();
            this.btnRunRecurring = new System.Windows.Forms.Button();
            this.btnRunOne = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.domainUpDownInterval = new System.Windows.Forms.DomainUpDown();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabCommand.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCommand);
            this.tabControl1.Controls.Add(this.tabResults);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCommand
            // 
            this.tabCommand.Controls.Add(this.btnRunRecurring);
            this.tabCommand.Controls.Add(this.btnRunOne);
            this.tabCommand.Controls.Add(this.label3);
            this.tabCommand.Controls.Add(this.label2);
            this.tabCommand.Controls.Add(this.label1);
            this.tabCommand.Controls.Add(this.txtConnectionString);
            this.tabCommand.Controls.Add(this.txtQuery);
            this.tabCommand.Controls.Add(this.domainUpDownInterval);
            this.tabCommand.Location = new System.Drawing.Point(4, 22);
            this.tabCommand.Name = "tabCommand";
            this.tabCommand.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommand.Size = new System.Drawing.Size(903, 561);
            this.tabCommand.TabIndex = 0;
            this.tabCommand.Text = "Command and Control";
            this.tabCommand.UseVisualStyleBackColor = true;
            // 
            // btnRunRecurring
            // 
            this.btnRunRecurring.Location = new System.Drawing.Point(99, 13);
            this.btnRunRecurring.Name = "btnRunRecurring";
            this.btnRunRecurring.Size = new System.Drawing.Size(100, 23);
            this.btnRunRecurring.TabIndex = 7;
            this.btnRunRecurring.Text = "Run Recurringly";
            this.btnRunRecurring.UseVisualStyleBackColor = true;
            // 
            // btnRunOne
            // 
            this.btnRunOne.Location = new System.Drawing.Point(17, 417);
            this.btnRunOne.Name = "btnRunOne";
            this.btnRunOne.Size = new System.Drawing.Size(88, 24);
            this.btnRunOne.TabIndex = 6;
            this.btnRunOne.Text = "Run Once";
            this.btnRunOne.UseVisualStyleBackColor = true;
            this.btnRunOne.Click += new System.EventHandler(this.BtnRunOne_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Query to Run";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Connection String";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interval";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnectionString.Location = new System.Drawing.Point(17, 72);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(878, 20);
            this.txtConnectionString.TabIndex = 2;
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtQuery.Location = new System.Drawing.Point(17, 128);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(878, 261);
            this.txtQuery.TabIndex = 1;
            this.txtQuery.Text = "";
            // 
            // domainUpDownInterval
            // 
            this.domainUpDownInterval.Items.Add("1");
            this.domainUpDownInterval.Items.Add("3");
            this.domainUpDownInterval.Items.Add("5");
            this.domainUpDownInterval.Items.Add("10");
            this.domainUpDownInterval.Items.Add("20");
            this.domainUpDownInterval.Items.Add("30");
            this.domainUpDownInterval.Items.Add("60");
            this.domainUpDownInterval.Items.Add("120");
            this.domainUpDownInterval.Items.Add("240");
            this.domainUpDownInterval.Items.Add("480");
            this.domainUpDownInterval.Items.Add("960");
            this.domainUpDownInterval.Location = new System.Drawing.Point(17, 13);
            this.domainUpDownInterval.Name = "domainUpDownInterval";
            this.domainUpDownInterval.Size = new System.Drawing.Size(63, 20);
            this.domainUpDownInterval.TabIndex = 0;
            this.domainUpDownInterval.SelectedItemChanged += new System.EventHandler(this.DomainUpDownInterval_SelectedItemChanged);
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.dgvResults);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(903, 561);
            this.tabResults.TabIndex = 1;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(3, 3);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(897, 555);
            this.dgvResults.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 587);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCommand.ResumeLayout(false);
            this.tabCommand.PerformLayout();
            this.tabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCommand;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.RichTextBox txtQuery;
        private System.Windows.Forms.DomainUpDown domainUpDownInterval;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnRunRecurring;
        private System.Windows.Forms.Button btnRunOne;
    }
}

