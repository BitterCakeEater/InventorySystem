namespace InventorySystem
{
    partial class Form_Add_Device
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_PC = new System.Windows.Forms.RadioButton();
            this.radioButton_Monitor = new System.Windows.Forms.RadioButton();
            this.radioButton_Printer = new System.Windows.Forms.RadioButton();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оберіть тип пристрою для додавання";
            // 
            // radioButton_PC
            // 
            this.radioButton_PC.AutoSize = true;
            this.radioButton_PC.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_PC.Location = new System.Drawing.Point(92, 41);
            this.radioButton_PC.Name = "radioButton_PC";
            this.radioButton_PC.Size = new System.Drawing.Size(48, 23);
            this.radioButton_PC.TabIndex = 1;
            this.radioButton_PC.TabStop = true;
            this.radioButton_PC.Text = "ПК";
            this.radioButton_PC.UseVisualStyleBackColor = true;
            // 
            // radioButton_Monitor
            // 
            this.radioButton_Monitor.AutoSize = true;
            this.radioButton_Monitor.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Monitor.Location = new System.Drawing.Point(92, 70);
            this.radioButton_Monitor.Name = "radioButton_Monitor";
            this.radioButton_Monitor.Size = new System.Drawing.Size(87, 23);
            this.radioButton_Monitor.TabIndex = 2;
            this.radioButton_Monitor.TabStop = true;
            this.radioButton_Monitor.Text = "Монітор";
            this.radioButton_Monitor.UseVisualStyleBackColor = true;
            // 
            // radioButton_Printer
            // 
            this.radioButton_Printer.AutoSize = true;
            this.radioButton_Printer.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Printer.Location = new System.Drawing.Point(92, 99);
            this.radioButton_Printer.Name = "radioButton_Printer";
            this.radioButton_Printer.Size = new System.Drawing.Size(91, 23);
            this.radioButton_Printer.TabIndex = 3;
            this.radioButton_Printer.TabStop = true;
            this.radioButton_Printer.Text = "Принтер";
            this.radioButton_Printer.UseVisualStyleBackColor = true;
            // 
            // button_Apply
            // 
            this.button_Apply.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Apply.Location = new System.Drawing.Point(15, 139);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 33);
            this.button_Apply.TabIndex = 4;
            this.button_Apply.Text = "Додати";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(195, 139);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(98, 33);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Скасувати";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Form_Add_Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 182);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.radioButton_Printer);
            this.Controls.Add(this.radioButton_Monitor);
            this.Controls.Add(this.radioButton_PC);
            this.Controls.Add(this.label1);
            this.Name = "Form_Add_Device";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Додати пристрій";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton radioButton_PC;
        public System.Windows.Forms.RadioButton radioButton_Monitor;
        public System.Windows.Forms.RadioButton radioButton_Printer;
        public System.Windows.Forms.Button button_Apply;
        public System.Windows.Forms.Button button_Cancel;
    }
}