namespace Animals
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AnimalGridView = new System.Windows.Forms.DataGridView();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 100);
            this.panel1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(13, 39);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 49);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AnimalGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 227);
            this.panel2.TabIndex = 1;
            // 
            // AnimalGridView
            // 
            this.AnimalGridView.AllowUserToAddRows = false;
            this.AnimalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnimalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameColumn,
            this.LastNameColumn,
            this.BirthdateColumn,
            this.PetNameColumn,
            this.idClientColumn});
            this.AnimalGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnimalGridView.Location = new System.Drawing.Point(0, 0);
            this.AnimalGridView.Name = "AnimalGridView";
            this.AnimalGridView.Size = new System.Drawing.Size(407, 227);
            this.AnimalGridView.TabIndex = 0;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.DataPropertyName = "ClientFirstName";
            this.FirstNameColumn.HeaderText = "First name";
            this.FirstNameColumn.Name = "FirstNameColumn";
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.DataPropertyName = "ClientLastName";
            this.LastNameColumn.HeaderText = "Last name";
            this.LastNameColumn.Name = "LastNameColumn";
            // 
            // BirthdateColumn
            // 
            this.BirthdateColumn.DataPropertyName = "BirthDate";
            this.BirthdateColumn.HeaderText = "Birthdate";
            this.BirthdateColumn.Name = "BirthdateColumn";
            // 
            // PetNameColumn
            // 
            this.PetNameColumn.DataPropertyName = "PetName";
            this.PetNameColumn.HeaderText = "Pet name";
            this.PetNameColumn.Name = "PetNameColumn";
            // 
            // idClientColumn
            // 
            this.idClientColumn.DataPropertyName = "idClient";
            this.idClientColumn.HeaderText = "idClient";
            this.idClientColumn.Name = "idClientColumn";
            this.idClientColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 327);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AnimalGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView AnimalGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthdateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientColumn;
    }
}

