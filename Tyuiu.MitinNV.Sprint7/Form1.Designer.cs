namespace Tyuiu.MitinNV.Sprint7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Dispose method to clean up resources.
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
        /// Designer support method - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuildingNumber = new System.Windows.Forms.TextBox();
            this.txtApartmentNumber = new System.Windows.Forms.TextBox();
            this.txtTotalArea = new System.Windows.Forms.TextBox();
            this.txtUsefulArea = new System.Windows.Forms.TextBox();
            this.txtNumberOfRooms = new System.Windows.Forms.TextBox();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.txtFamilyMembersCount = new System.Windows.Forms.TextBox();
            this.txtChildrenCount = new System.Windows.Forms.TextBox();
            this.chkHasDebt = new System.Windows.Forms.CheckBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnAddApartment = new System.Windows.Forms.Button();
            this.dgvApartments = new System.Windows.Forms.DataGridView();
            this.btnDeleteApartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.Location = new System.Drawing.Point(14, 16);
            this.txtBuildingNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.PlaceholderText = "№ здания";
            this.txtBuildingNumber.Size = new System.Drawing.Size(114, 27);
            this.txtBuildingNumber.TabIndex = 0;
            // 
            // txtApartmentNumber
            // 
            this.txtApartmentNumber.Location = new System.Drawing.Point(135, 16);
            this.txtApartmentNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApartmentNumber.Name = "txtApartmentNumber";
            this.txtApartmentNumber.PlaceholderText = "№ квартиры";
            this.txtApartmentNumber.Size = new System.Drawing.Size(114, 27);
            this.txtApartmentNumber.TabIndex = 1;
            // 
            // txtTotalArea
            // 
            this.txtTotalArea.Location = new System.Drawing.Point(256, 16);
            this.txtTotalArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalArea.Name = "txtTotalArea";
            this.txtTotalArea.PlaceholderText = "Общая площадь";
            this.txtTotalArea.Size = new System.Drawing.Size(114, 27);
            this.txtTotalArea.TabIndex = 2;
            // 
            // txtUsefulArea
            // 
            this.txtUsefulArea.Location = new System.Drawing.Point(377, 16);
            this.txtUsefulArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsefulArea.Name = "txtUsefulArea";
            this.txtUsefulArea.PlaceholderText = "Полезная площадь";
            this.txtUsefulArea.Size = new System.Drawing.Size(114, 27);
            this.txtUsefulArea.TabIndex = 3;
            // 
            // txtNumberOfRooms
            // 
            this.txtNumberOfRooms.Location = new System.Drawing.Point(498, 16);
            this.txtNumberOfRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberOfRooms.Name = "txtNumberOfRooms";
            this.txtNumberOfRooms.PlaceholderText = "Кол-во комнат";
            this.txtNumberOfRooms.Size = new System.Drawing.Size(114, 27);
            this.txtNumberOfRooms.TabIndex = 4;
            // 
            // txtTenantName
            // 
            this.txtTenantName.Location = new System.Drawing.Point(619, 16);
            this.txtTenantName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.PlaceholderText = "ФИО арендатора";
            this.txtTenantName.Size = new System.Drawing.Size(114, 27);
            this.txtTenantName.TabIndex = 5;
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.Location = new System.Drawing.Point(741, 16);
            this.dtpRegistrationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(228, 27);
            this.dtpRegistrationDate.TabIndex = 6;
            // 
            // txtFamilyMembersCount
            // 
            this.txtFamilyMembersCount.Location = new System.Drawing.Point(976, 16);
            this.txtFamilyMembersCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFamilyMembersCount.Name = "txtFamilyMembersCount";
            this.txtFamilyMembersCount.PlaceholderText = "Кол-во членов семьи";
            this.txtFamilyMembersCount.Size = new System.Drawing.Size(114, 27);
            this.txtFamilyMembersCount.TabIndex = 7;
            // 
            // txtChildrenCount
            // 
            this.txtChildrenCount.Location = new System.Drawing.Point(1097, 16);
            this.txtChildrenCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChildrenCount.Name = "txtChildrenCount";
            this.txtChildrenCount.PlaceholderText = "Кол-во детей";
            this.txtChildrenCount.Size = new System.Drawing.Size(114, 27);
            this.txtChildrenCount.TabIndex = 8;
            // 
            // chkHasDebt
            // 
            this.chkHasDebt.AutoSize = true;
            this.chkHasDebt.Location = new System.Drawing.Point(1218, 20);
            this.chkHasDebt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkHasDebt.Name = "chkHasDebt";
            this.chkHasDebt.Size = new System.Drawing.Size(139, 24);
            this.chkHasDebt.TabIndex = 9;
            this.chkHasDebt.Text = "Задолженность";
            this.chkHasDebt.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(14, 55);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "Примечания";
            this.txtNotes.Size = new System.Drawing.Size(1343, 79);
            this.txtNotes.TabIndex = 10;
            // 
            // btnAddApartment
            // 
            this.btnAddApartment.Location = new System.Drawing.Point(14, 143);
            this.btnAddApartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddApartment.Name = "btnAddApartment";
            this.btnAddApartment.Size = new System.Drawing.Size(229, 31);
            this.btnAddApartment.TabIndex = 11;
            this.btnAddApartment.Text = "Добавить";
            this.btnAddApartment.UseVisualStyleBackColor = true;
            this.btnAddApartment.Click += new System.EventHandler(this.btnAddApartment_Click);
            // 
            // dgvApartments
            // 
            this.dgvApartments.AllowUserToAddRows = false;
            this.dgvApartments.AllowUserToDeleteRows = false;
            this.dgvApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartments.Location = new System.Drawing.Point(14, 181);
            this.dgvApartments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvApartments.Name = "dgvApartments";
            this.dgvApartments.ReadOnly = true;
            this.dgvApartments.RowHeadersWidth = 51;
            this.dgvApartments.Size = new System.Drawing.Size(1341, 403);
            this.dgvApartments.TabIndex = 12;
            // 
            // btnDeleteApartment
            // 
            this.btnDeleteApartment.Location = new System.Drawing.Point(249, 143);
            this.btnDeleteApartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteApartment.Name = "btnDeleteApartment";
            this.btnDeleteApartment.Size = new System.Drawing.Size(229, 31);
            this.btnDeleteApartment.TabIndex = 13;
            this.btnDeleteApartment.Text = "Удалить";
            this.btnDeleteApartment.UseVisualStyleBackColor = true;
            this.btnDeleteApartment.Click += new System.EventHandler(this.btnDeleteApartment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 600);
            this.Controls.Add(this.dgvApartments);
            this.Controls.Add(this.btnAddApartment);
            this.Controls.Add(this.btnDeleteApartment);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.chkHasDebt);
            this.Controls.Add(this.txtChildrenCount);
            this.Controls.Add(this.txtFamilyMembersCount);
            this.Controls.Add(this.dtpRegistrationDate);
            this.Controls.Add(this.txtTenantName);
            this.Controls.Add(this.txtNumberOfRooms);
            this.Controls.Add(this.txtUsefulArea);
            this.Controls.Add(this.txtTotalArea);
            this.Controls.Add(this.txtApartmentNumber);
            this.Controls.Add(this.txtBuildingNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Митин Никита | ИИПб-24-1 | Спринт #7";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtBuildingNumber;
        private System.Windows.Forms.TextBox txtApartmentNumber;
        private System.Windows.Forms.TextBox txtTotalArea;
        private System.Windows.Forms.TextBox txtUsefulArea;
        private System.Windows.Forms.TextBox txtNumberOfRooms;
        private System.Windows.Forms.TextBox txtTenantName;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
        private System.Windows.Forms.TextBox txtFamilyMembersCount;
        private System.Windows.Forms.TextBox txtChildrenCount;
        private System.Windows.Forms.CheckBox chkHasDebt;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAddApartment;
        private System.Windows.Forms.DataGridView dgvApartments;
        private System.Windows.Forms.Button btnDeleteApartment;
    }
}
