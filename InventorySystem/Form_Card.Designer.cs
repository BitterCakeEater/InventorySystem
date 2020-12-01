namespace InventorySystem
{
    partial class Form_Card
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Card));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Card = new System.Windows.Forms.DataGridView();
            this.Column_Reader_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Reader_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Issue_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Term_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Return_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Cipher = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Card)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Card
            // 
            this.dataGridView_Card.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_Card.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridView_Card, "dataGridView_Card");
            this.dataGridView_Card.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Card.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Card.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Card.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Card.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Reader_Name,
            this.Column_Reader_Number,
            this.Column_Issue_Date,
            this.Column_Term_Date,
            this.Column_Return_Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Card.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Card.MultiSelect = false;
            this.dataGridView_Card.Name = "dataGridView_Card";
            this.dataGridView_Card.RowHeadersVisible = false;
            this.dataGridView_Card.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Column_Reader_Name
            // 
            resources.ApplyResources(this.Column_Reader_Name, "Column_Reader_Name");
            this.Column_Reader_Name.Name = "Column_Reader_Name";
            this.Column_Reader_Name.ReadOnly = true;
            // 
            // Column_Reader_Number
            // 
            resources.ApplyResources(this.Column_Reader_Number, "Column_Reader_Number");
            this.Column_Reader_Number.Name = "Column_Reader_Number";
            this.Column_Reader_Number.ReadOnly = true;
            // 
            // Column_Issue_Date
            // 
            resources.ApplyResources(this.Column_Issue_Date, "Column_Issue_Date");
            this.Column_Issue_Date.Name = "Column_Issue_Date";
            this.Column_Issue_Date.ReadOnly = true;
            // 
            // Column_Term_Date
            // 
            resources.ApplyResources(this.Column_Term_Date, "Column_Term_Date");
            this.Column_Term_Date.Name = "Column_Term_Date";
            this.Column_Term_Date.ReadOnly = true;
            // 
            // Column_Return_Date
            // 
            resources.ApplyResources(this.Column_Return_Date, "Column_Return_Date");
            this.Column_Return_Date.Name = "Column_Return_Date";
            this.Column_Return_Date.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label_Cipher
            // 
            resources.ApplyResources(this.label_Cipher, "label_Cipher");
            this.label_Cipher.Name = "label_Cipher";
            // 
            // label_Number
            // 
            resources.ApplyResources(this.label_Number, "label_Number");
            this.label_Number.Name = "label_Number";
            // 
            // Form_Card
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Number);
            this.Controls.Add(this.label_Cipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Card);
            this.Name = "Form_Card";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Card)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Card;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Cipher;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Reader_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Reader_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Issue_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Term_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Return_Date;
    }
}