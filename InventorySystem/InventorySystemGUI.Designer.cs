namespace InventorySystem
{
    partial class LibraryGUI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryGUI));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Catalog = new System.Windows.Forms.TabPage();
            this.button_ChangeInfo = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.button_Find = new System.Windows.Forms.Button();
            this.textBox_Input_To_Find = new System.Windows.Forms.TextBox();
            this.button_Delete_Section = new System.Windows.Forms.Button();
            this.button_Add_Section = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.Column_OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DeviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage_Catalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage_Catalog);
            this.tabControl.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(4, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1044, 467);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_Catalog
            // 
            this.tabPage_Catalog.Controls.Add(this.button_ChangeInfo);
            this.tabPage_Catalog.Controls.Add(this.button_Info);
            this.tabPage_Catalog.Controls.Add(this.button_Find);
            this.tabPage_Catalog.Controls.Add(this.textBox_Input_To_Find);
            this.tabPage_Catalog.Controls.Add(this.button_Delete_Section);
            this.tabPage_Catalog.Controls.Add(this.button_Add_Section);
            this.tabPage_Catalog.Controls.Add(this.label2);
            this.tabPage_Catalog.Controls.Add(this.dataGridView_List);
            this.tabPage_Catalog.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Catalog.Name = "tabPage_Catalog";
            this.tabPage_Catalog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Catalog.Size = new System.Drawing.Size(1036, 438);
            this.tabPage_Catalog.TabIndex = 2;
            this.tabPage_Catalog.Text = "Каталог";
            this.tabPage_Catalog.UseVisualStyleBackColor = true;
            // 
            // button_ChangeInfo
            // 
            this.button_ChangeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ChangeInfo.BackColor = System.Drawing.Color.Snow;
            this.button_ChangeInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChangeInfo.Location = new System.Drawing.Point(182, 406);
            this.button_ChangeInfo.Name = "button_ChangeInfo";
            this.button_ChangeInfo.Size = new System.Drawing.Size(160, 29);
            this.button_ChangeInfo.TabIndex = 9;
            this.button_ChangeInfo.Text = "Змінити інформацію";
            this.button_ChangeInfo.UseVisualStyleBackColor = false;
            this.button_ChangeInfo.Click += new System.EventHandler(this.button_ChangeInfo_Click);
            // 
            // button_Info
            // 
            this.button_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Info.BackColor = System.Drawing.Color.Snow;
            this.button_Info.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Info.Location = new System.Drawing.Point(6, 406);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(170, 29);
            this.button_Info.TabIndex = 8;
            this.button_Info.Text = "Детальніше про пристрій";
            this.button_Info.UseVisualStyleBackColor = false;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // button_Find
            // 
            this.button_Find.BackColor = System.Drawing.Color.Snow;
            this.button_Find.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Find.Location = new System.Drawing.Point(390, 6);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(75, 31);
            this.button_Find.TabIndex = 7;
            this.button_Find.Text = "Пошук";
            this.button_Find.UseVisualStyleBackColor = false;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // textBox_Input_To_Find
            // 
            this.textBox_Input_To_Find.Location = new System.Drawing.Point(178, 12);
            this.textBox_Input_To_Find.Name = "textBox_Input_To_Find";
            this.textBox_Input_To_Find.Size = new System.Drawing.Size(206, 23);
            this.textBox_Input_To_Find.TabIndex = 6;
            // 
            // button_Delete_Section
            // 
            this.button_Delete_Section.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Delete_Section.BackColor = System.Drawing.Color.Snow;
            this.button_Delete_Section.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete_Section.Location = new System.Drawing.Point(348, 406);
            this.button_Delete_Section.Name = "button_Delete_Section";
            this.button_Delete_Section.Size = new System.Drawing.Size(132, 29);
            this.button_Delete_Section.TabIndex = 4;
            this.button_Delete_Section.Text = "Видалити пристрій";
            this.button_Delete_Section.UseVisualStyleBackColor = false;
            this.button_Delete_Section.Click += new System.EventHandler(this.button_Delete_Section_Click);
            // 
            // button_Add_Section
            // 
            this.button_Add_Section.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add_Section.BackColor = System.Drawing.Color.Snow;
            this.button_Add_Section.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add_Section.Location = new System.Drawing.Point(870, 409);
            this.button_Add_Section.Name = "button_Add_Section";
            this.button_Add_Section.Size = new System.Drawing.Size(160, 29);
            this.button_Add_Section.TabIndex = 2;
            this.button_Add_Section.Text = "Додати новий пристрій";
            this.button_Add_Section.UseVisualStyleBackColor = false;
            this.button_Add_Section.Click += new System.EventHandler(this.button_Add_Section_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Список пристроїв";
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.AllowUserToAddRows = false;
            this.dataGridView_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_List.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_OrderNumber,
            this.Column_ID,
            this.Column_DeviceName,
            this.Column_DeviceType,
            this.Column_RegistrationDate});
            this.dataGridView_List.Location = new System.Drawing.Point(4, 42);
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.RowHeadersVisible = false;
            this.dataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_List.Size = new System.Drawing.Size(1026, 355);
            this.dataGridView_List.TabIndex = 0;
            // 
            // Column_OrderNumber
            // 
            this.Column_OrderNumber.FillWeight = 111.9404F;
            this.Column_OrderNumber.HeaderText = "№";
            this.Column_OrderNumber.Name = "Column_OrderNumber";
            this.Column_OrderNumber.ReadOnly = true;
            // 
            // Column_ID
            // 
            this.Column_ID.FillWeight = 111.9404F;
            this.Column_ID.HeaderText = "Обліковий номер";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            // 
            // Column_DeviceName
            // 
            this.Column_DeviceName.FillWeight = 111.9404F;
            this.Column_DeviceName.HeaderText = "Назва пристрою";
            this.Column_DeviceName.Name = "Column_DeviceName";
            this.Column_DeviceName.ReadOnly = true;
            // 
            // Column_DeviceType
            // 
            this.Column_DeviceType.HeaderText = "Тип";
            this.Column_DeviceType.Name = "Column_DeviceType";
            // 
            // Column_RegistrationDate
            // 
            this.Column_RegistrationDate.FillWeight = 111.9404F;
            this.Column_RegistrationDate.HeaderText = "Дата реєстрації";
            this.Column_RegistrationDate.Name = "Column_RegistrationDate";
            this.Column_RegistrationDate.ReadOnly = true;
            // 
            // LibraryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 485);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 320);
            this.Name = "LibraryGUI";
            this.Text = "INVEDIT";
            this.tabControl.ResumeLayout(false);
            this.tabPage_Catalog.ResumeLayout(false);
            this.tabPage_Catalog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Catalog;
        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Add_Section;
        private System.Windows.Forms.Button button_Delete_Section;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.TextBox textBox_Input_To_Find;
        private System.Windows.Forms.Button button_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_RegistrationDate;
        private System.Windows.Forms.Button button_ChangeInfo;
    }
}

