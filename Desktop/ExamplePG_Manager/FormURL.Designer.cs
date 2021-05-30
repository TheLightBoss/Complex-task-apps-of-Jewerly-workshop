
namespace ExamplePG_Manager
{
    partial class FormURL
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
            this.textBox_urlIzd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_urlIzd
            // 
            this.textBox_urlIzd.Location = new System.Drawing.Point(13, 32);
            this.textBox_urlIzd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_urlIzd.Multiline = true;
            this.textBox_urlIzd.Name = "textBox_urlIzd";
            this.textBox_urlIzd.Size = new System.Drawing.Size(474, 180);
            this.textBox_urlIzd.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(503, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_urlIzd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormURL";
            this.Text = "Текст";
            this.Load += new System.EventHandler(this.FormURL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_urlIzd;
        private System.Windows.Forms.Button button1;
    }
}