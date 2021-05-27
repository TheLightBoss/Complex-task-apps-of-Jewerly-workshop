
namespace ExamplePG_Manager
{
    partial class Form_SearchMats
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
            this.dvg_Mats = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Banks = new System.Windows.Forms.ComboBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Mats)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_Mats
            // 
            this.dvg_Mats.AllowUserToAddRows = false;
            this.dvg_Mats.AllowUserToDeleteRows = false;
            this.dvg_Mats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_Mats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvg_Mats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Mats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_URL,
            this.Column_Price,
            this.Column_Bank});
            this.dvg_Mats.Location = new System.Drawing.Point(12, 76);
            this.dvg_Mats.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dvg_Mats.Name = "dvg_Mats";
            this.dvg_Mats.ReadOnly = true;
            this.dvg_Mats.Size = new System.Drawing.Size(664, 265);
            this.dvg_Mats.TabIndex = 2;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Название";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_URL
            // 
            this.Column_URL.HeaderText = "URL";
            this.Column_URL.Name = "Column_URL";
            this.Column_URL.ReadOnly = true;
            // 
            // Column_Price
            // 
            this.Column_Price.HeaderText = "Цена";
            this.Column_Price.Name = "Column_Price";
            this.Column_Price.ReadOnly = true;
            // 
            // Column_Bank
            // 
            this.Column_Bank.HeaderText = "Банк";
            this.Column_Bank.Name = "Column_Bank";
            this.Column_Bank.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Банк";
            // 
            // comboBox_Banks
            // 
            this.comboBox_Banks.FormattingEnabled = true;
            this.comboBox_Banks.Location = new System.Drawing.Point(72, 32);
            this.comboBox_Banks.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.comboBox_Banks.Name = "comboBox_Banks";
            this.comboBox_Banks.Size = new System.Drawing.Size(138, 28);
            this.comboBox_Banks.TabIndex = 6;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(257, 32);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(131, 26);
            this.textBox_name.TabIndex = 8;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(428, 28);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(121, 33);
            this.btn_Find.TabIndex = 9;
            this.btn_Find.Text = "Поиск";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // Form_SearchMats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 363);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Banks);
            this.Controls.Add(this.dvg_Mats);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_SearchMats";
            this.Text = "Form_SearchMats";
            this.Load += new System.EventHandler(this.Form_SearchMats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Mats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_Mats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Banks;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Bank;
    }
}