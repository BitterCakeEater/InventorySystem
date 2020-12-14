namespace InventorySystem.Classes
{
    partial class Form_Save_Attention
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Save_Attention));
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Decline = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Apply
            // 
            this.button_Apply.BackColor = System.Drawing.Color.Snow;
            this.button_Apply.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button_Apply.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Apply.Location = new System.Drawing.Point(12, 49);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 26);
            this.button_Apply.TabIndex = 0;
            this.button_Apply.Text = "Так";
            this.button_Apply.UseVisualStyleBackColor = false;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_Decline
            // 
            this.button_Decline.BackColor = System.Drawing.Color.Snow;
            this.button_Decline.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_Decline.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Decline.Location = new System.Drawing.Point(213, 49);
            this.button_Decline.Name = "button_Decline";
            this.button_Decline.Size = new System.Drawing.Size(75, 26);
            this.button_Decline.TabIndex = 1;
            this.button_Decline.Text = "Ні";
            this.button_Decline.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ви бажаєте зберегти зміни?";
            // 
            // Form_Save_Attention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 87);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Decline);
            this.Controls.Add(this.button_Apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Save_Attention";
            this.Text = "Увага!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Decline;
        public System.Windows.Forms.Label label1;
    }
}