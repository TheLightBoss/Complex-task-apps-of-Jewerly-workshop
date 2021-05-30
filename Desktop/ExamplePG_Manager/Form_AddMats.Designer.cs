
namespace ExamplePG_Manager
{
    partial class Form_AddMats
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
            this.comboBox_Banks = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_Banks
            // 
            this.comboBox_Banks.FormattingEnabled = true;
            this.comboBox_Banks.Location = new System.Drawing.Point(129, 197);
            this.comboBox_Banks.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Banks.Name = "comboBox_Banks";
            this.comboBox_Banks.Size = new System.Drawing.Size(219, 32);
            this.comboBox_Banks.TabIndex = 0;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(129, 20);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(219, 29);
            this.textBox_Name.TabIndex = 1;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(129, 136);
            this.textBox_Price.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(219, 29);
            this.textBox_Price.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Банк";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(129, 265);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(131, 45);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "URL";
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(129, 80);
            this.textBox_url.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(219, 29);
            this.textBox_url.TabIndex = 7;
            // 
            // Form_AddMats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 354);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.comboBox_Banks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_AddMats";
            this.Text = "Form_AddMats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Banks;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_url;
    }
}