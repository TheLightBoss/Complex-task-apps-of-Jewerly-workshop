
namespace ExamplePG_Manager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.jewerlyDataSet = new ExamplePG_Manager.jewerlyDataSet();
            this.izdeliesprBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdelie_sprTableAdapter = new ExamplePG_Manager.jewerlyDataSetTableAdapters.izdelie_sprTableAdapter();
            this.tabPage_sotrudnik = new System.Windows.Forms.TabPage();
            this.button_addmaster = new System.Windows.Forms.Button();
            this.button_savemaster = new System.Windows.Forms.Button();
            this.button_downmaster = new System.Windows.Forms.Button();
            this.button_upmaster = new System.Windows.Forms.Button();
            this.numericUpDown_Stag = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.tabPage_DataMain = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dvg_Mats = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PriceOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tabPage_izdSpr = new System.Windows.Forms.TabPage();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.pictureBox_Izd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_rabota = new System.Windows.Forms.TextBox();
            this.label_nameItm = new System.Windows.Forms.Label();
            this.textBox_nameweb = new System.Windows.Forms.TextBox();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.label_url = new System.Windows.Forms.Label();
            this.textBox_urlIzd = new System.Windows.Forms.TextBox();
            this.comboBox_tipIzd = new System.Windows.Forms.ComboBox();
            this.label_tipIzd = new System.Windows.Forms.Label();
            this.comboBox_mats = new System.Windows.Forms.ComboBox();
            this.label_mats = new System.Windows.Forms.Label();
            this.label_nameIzd = new System.Windows.Forms.Label();
            this.textBox_nameIzd = new System.Windows.Forms.TextBox();
            this.tabPage_Zakazs = new System.Windows.Forms.TabPage();
            this.dgv_ZakazMain = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Izdel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ContactInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton_readyZakaz = new System.Windows.Forms.RadioButton();
            this.radioButton_loadZakaz = new System.Windows.Forms.RadioButton();
            this.radioButton_newZakaz = new System.Windows.Forms.RadioButton();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.jewerlyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdeliesprBindingSource)).BeginInit();
            this.tabPage_sotrudnik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Stag)).BeginInit();
            this.tabPage_DataMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Mats)).BeginInit();
            this.tabPage_izdSpr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Izd)).BeginInit();
            this.tabPage_Zakazs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ZakazMain)).BeginInit();
            this.tabControl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // jewerlyDataSet
            // 
            this.jewerlyDataSet.DataSetName = "jewerlyDataSet";
            this.jewerlyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izdeliesprBindingSource
            // 
            this.izdeliesprBindingSource.DataMember = "izdelie_spr";
            this.izdeliesprBindingSource.DataSource = this.jewerlyDataSet;
            // 
            // izdelie_sprTableAdapter
            // 
            this.izdelie_sprTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage_sotrudnik
            // 
            this.tabPage_sotrudnik.Controls.Add(this.button_addmaster);
            this.tabPage_sotrudnik.Controls.Add(this.button_savemaster);
            this.tabPage_sotrudnik.Controls.Add(this.button_downmaster);
            this.tabPage_sotrudnik.Controls.Add(this.button_upmaster);
            this.tabPage_sotrudnik.Controls.Add(this.numericUpDown_Stag);
            this.tabPage_sotrudnik.Controls.Add(this.label6);
            this.tabPage_sotrudnik.Controls.Add(this.label4);
            this.tabPage_sotrudnik.Controls.Add(this.label5);
            this.tabPage_sotrudnik.Controls.Add(this.textBox_address);
            this.tabPage_sotrudnik.Controls.Add(this.textBox_password);
            this.tabPage_sotrudnik.Controls.Add(this.label3);
            this.tabPage_sotrudnik.Controls.Add(this.label2);
            this.tabPage_sotrudnik.Controls.Add(this.textBox_login);
            this.tabPage_sotrudnik.Controls.Add(this.textBox_fio);
            this.tabPage_sotrudnik.Location = new System.Drawing.Point(4, 29);
            this.tabPage_sotrudnik.Name = "tabPage_sotrudnik";
            this.tabPage_sotrudnik.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_sotrudnik.Size = new System.Drawing.Size(973, 583);
            this.tabPage_sotrudnik.TabIndex = 3;
            this.tabPage_sotrudnik.Text = "Сотрудники";
            this.tabPage_sotrudnik.UseVisualStyleBackColor = true;
            this.tabPage_sotrudnik.Enter += new System.EventHandler(this.tabPage_sotrudnik_Enter);
            // 
            // button_addmaster
            // 
            this.button_addmaster.Location = new System.Drawing.Point(155, 475);
            this.button_addmaster.Name = "button_addmaster";
            this.button_addmaster.Size = new System.Drawing.Size(150, 46);
            this.button_addmaster.TabIndex = 13;
            this.button_addmaster.Text = "Добавить ";
            this.button_addmaster.UseVisualStyleBackColor = true;
            this.button_addmaster.Visible = false;
            this.button_addmaster.Click += new System.EventHandler(this.button_addmaster_Click);
            // 
            // button_savemaster
            // 
            this.button_savemaster.Location = new System.Drawing.Point(142, 423);
            this.button_savemaster.Name = "button_savemaster";
            this.button_savemaster.Size = new System.Drawing.Size(189, 46);
            this.button_savemaster.TabIndex = 12;
            this.button_savemaster.Text = "Сохранить изменения";
            this.button_savemaster.UseVisualStyleBackColor = true;
            this.button_savemaster.Click += new System.EventHandler(this.button_savemaster_Click);
            // 
            // button_downmaster
            // 
            this.button_downmaster.Location = new System.Drawing.Point(101, 361);
            this.button_downmaster.Name = "button_downmaster";
            this.button_downmaster.Size = new System.Drawing.Size(77, 56);
            this.button_downmaster.TabIndex = 11;
            this.button_downmaster.Text = "<";
            this.button_downmaster.UseVisualStyleBackColor = true;
            this.button_downmaster.Click += new System.EventHandler(this.button_downmaster_Click);
            // 
            // button_upmaster
            // 
            this.button_upmaster.Location = new System.Drawing.Point(315, 361);
            this.button_upmaster.Name = "button_upmaster";
            this.button_upmaster.Size = new System.Drawing.Size(77, 56);
            this.button_upmaster.TabIndex = 10;
            this.button_upmaster.Text = ">";
            this.button_upmaster.UseVisualStyleBackColor = true;
            this.button_upmaster.Click += new System.EventHandler(this.button_upmaster_Click);
            // 
            // numericUpDown_Stag
            // 
            this.numericUpDown_Stag.Location = new System.Drawing.Point(172, 309);
            this.numericUpDown_Stag.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown_Stag.Name = "numericUpDown_Stag";
            this.numericUpDown_Stag.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Stag.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Стаж работы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Пароль";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(172, 250);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(220, 26);
            this.textBox_address.TabIndex = 5;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(172, 181);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(220, 26);
            this.textBox_password.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО ";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(172, 107);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(220, 26);
            this.textBox_login.TabIndex = 1;
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(172, 38);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(220, 26);
            this.textBox_fio.TabIndex = 0;
            // 
            // tabPage_DataMain
            // 
            this.tabPage_DataMain.Controls.Add(this.tabControl1);
            this.tabPage_DataMain.Location = new System.Drawing.Point(4, 29);
            this.tabPage_DataMain.Name = "tabPage_DataMain";
            this.tabPage_DataMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DataMain.Size = new System.Drawing.Size(973, 583);
            this.tabPage_DataMain.TabIndex = 2;
            this.tabPage_DataMain.Text = "Справочники";
            this.tabPage_DataMain.UseVisualStyleBackColor = true;
            this.tabPage_DataMain.Enter += new System.EventHandler(this.tabPage_DataMain_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage_izdSpr);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 560);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dvg_Mats);
            this.tabPage2.Controls.Add(this.btn_Search);
            this.tabPage2.Controls.Add(this.btn_Add);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(953, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Материалы";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter_1);
            // 
            // dvg_Mats
            // 
            this.dvg_Mats.AllowUserToAddRows = false;
            this.dvg_Mats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_Mats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvg_Mats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Mats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_URL,
            this.Column_PriceOne,
            this.Column_bank});
            this.dvg_Mats.Location = new System.Drawing.Point(21, 33);
            this.dvg_Mats.Name = "dvg_Mats";
            this.dvg_Mats.Size = new System.Drawing.Size(631, 242);
            this.dvg_Mats.TabIndex = 1;
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
            // Column_PriceOne
            // 
            this.Column_PriceOne.HeaderText = "Цена";
            this.Column_PriceOne.Name = "Column_PriceOne";
            this.Column_PriceOne.ReadOnly = true;
            // 
            // Column_bank
            // 
            this.Column_bank.HeaderText = "Банк";
            this.Column_bank.Name = "Column_bank";
            this.Column_bank.ReadOnly = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(173, 281);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(149, 48);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Поиск";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(395, 281);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(158, 48);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tabPage_izdSpr
            // 
            this.tabPage_izdSpr.Controls.Add(this.btn_Insert);
            this.tabPage_izdSpr.Controls.Add(this.btn_Update);
            this.tabPage_izdSpr.Controls.Add(this.pictureBox_Izd);
            this.tabPage_izdSpr.Controls.Add(this.label1);
            this.tabPage_izdSpr.Controls.Add(this.textBox_rabota);
            this.tabPage_izdSpr.Controls.Add(this.label_nameItm);
            this.tabPage_izdSpr.Controls.Add(this.textBox_nameweb);
            this.tabPage_izdSpr.Controls.Add(this.btn_up);
            this.tabPage_izdSpr.Controls.Add(this.btn_down);
            this.tabPage_izdSpr.Controls.Add(this.label_url);
            this.tabPage_izdSpr.Controls.Add(this.textBox_urlIzd);
            this.tabPage_izdSpr.Controls.Add(this.comboBox_tipIzd);
            this.tabPage_izdSpr.Controls.Add(this.label_tipIzd);
            this.tabPage_izdSpr.Controls.Add(this.comboBox_mats);
            this.tabPage_izdSpr.Controls.Add(this.label_mats);
            this.tabPage_izdSpr.Controls.Add(this.label_nameIzd);
            this.tabPage_izdSpr.Controls.Add(this.textBox_nameIzd);
            this.tabPage_izdSpr.Location = new System.Drawing.Point(4, 29);
            this.tabPage_izdSpr.Name = "tabPage_izdSpr";
            this.tabPage_izdSpr.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_izdSpr.Size = new System.Drawing.Size(953, 527);
            this.tabPage_izdSpr.TabIndex = 2;
            this.tabPage_izdSpr.Text = "Изделия";
            this.tabPage_izdSpr.UseVisualStyleBackColor = true;
            this.tabPage_izdSpr.Enter += new System.EventHandler(this.tabPage_izdSpr_Enter);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(456, 426);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(233, 50);
            this.btn_Insert.TabIndex = 17;
            this.btn_Insert.Text = "Добавить новое изделие";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(730, 426);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(193, 50);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "Сохранить изменения";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Izd
            // 
            this.pictureBox_Izd.Location = new System.Drawing.Point(402, 6);
            this.pictureBox_Izd.Name = "pictureBox_Izd";
            this.pictureBox_Izd.Size = new System.Drawing.Size(496, 392);
            this.pictureBox_Izd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Izd.TabIndex = 15;
            this.pictureBox_Izd.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Список работ";
            // 
            // textBox_rabota
            // 
            this.textBox_rabota.Location = new System.Drawing.Point(79, 384);
            this.textBox_rabota.Multiline = true;
            this.textBox_rabota.Name = "textBox_rabota";
            this.textBox_rabota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_rabota.Size = new System.Drawing.Size(303, 148);
            this.textBox_rabota.TabIndex = 13;
            // 
            // label_nameItm
            // 
            this.label_nameItm.AutoSize = true;
            this.label_nameItm.Location = new System.Drawing.Point(75, 298);
            this.label_nameItm.Name = "label_nameItm";
            this.label_nameItm.Size = new System.Drawing.Size(194, 20);
            this.label_nameItm.TabIndex = 12;
            this.label_nameItm.Text = "Название поля на сайте";
            // 
            // textBox_nameweb
            // 
            this.textBox_nameweb.Location = new System.Drawing.Point(79, 321);
            this.textBox_nameweb.Name = "textBox_nameweb";
            this.textBox_nameweb.Size = new System.Drawing.Size(190, 26);
            this.textBox_nameweb.TabIndex = 11;
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(388, 483);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(61, 49);
            this.btn_up.TabIndex = 10;
            this.btn_up.Text = ">";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(18, 483);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(55, 44);
            this.btn_down.TabIndex = 9;
            this.btn_down.Text = "<";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(75, 229);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(116, 20);
            this.label_url.TabIndex = 8;
            this.label_url.Text = "URL картинки";
            // 
            // textBox_urlIzd
            // 
            this.textBox_urlIzd.Location = new System.Drawing.Point(79, 252);
            this.textBox_urlIzd.Name = "textBox_urlIzd";
            this.textBox_urlIzd.Size = new System.Drawing.Size(190, 26);
            this.textBox_urlIzd.TabIndex = 7;
            this.textBox_urlIzd.Click += new System.EventHandler(this.textBox_urlIzd_Click);
            // 
            // comboBox_tipIzd
            // 
            this.comboBox_tipIzd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipIzd.FormattingEnabled = true;
            this.comboBox_tipIzd.Location = new System.Drawing.Point(79, 181);
            this.comboBox_tipIzd.Name = "comboBox_tipIzd";
            this.comboBox_tipIzd.Size = new System.Drawing.Size(190, 28);
            this.comboBox_tipIzd.TabIndex = 6;
            // 
            // label_tipIzd
            // 
            this.label_tipIzd.AutoSize = true;
            this.label_tipIzd.Location = new System.Drawing.Point(75, 158);
            this.label_tipIzd.Name = "label_tipIzd";
            this.label_tipIzd.Size = new System.Drawing.Size(105, 20);
            this.label_tipIzd.TabIndex = 5;
            this.label_tipIzd.Text = "Тип изделия";
            // 
            // comboBox_mats
            // 
            this.comboBox_mats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mats.FormattingEnabled = true;
            this.comboBox_mats.Location = new System.Drawing.Point(79, 125);
            this.comboBox_mats.Name = "comboBox_mats";
            this.comboBox_mats.Size = new System.Drawing.Size(190, 28);
            this.comboBox_mats.TabIndex = 4;
            // 
            // label_mats
            // 
            this.label_mats.AutoSize = true;
            this.label_mats.Location = new System.Drawing.Point(75, 102);
            this.label_mats.Name = "label_mats";
            this.label_mats.Size = new System.Drawing.Size(86, 20);
            this.label_mats.TabIndex = 3;
            this.label_mats.Text = "Материал";
            // 
            // label_nameIzd
            // 
            this.label_nameIzd.AutoSize = true;
            this.label_nameIzd.Location = new System.Drawing.Point(75, 38);
            this.label_nameIzd.Name = "label_nameIzd";
            this.label_nameIzd.Size = new System.Drawing.Size(152, 20);
            this.label_nameIzd.TabIndex = 1;
            this.label_nameIzd.Text = "Название изделия";
            // 
            // textBox_nameIzd
            // 
            this.textBox_nameIzd.Location = new System.Drawing.Point(79, 61);
            this.textBox_nameIzd.Name = "textBox_nameIzd";
            this.textBox_nameIzd.Size = new System.Drawing.Size(190, 26);
            this.textBox_nameIzd.TabIndex = 0;
            this.textBox_nameIzd.Click += new System.EventHandler(this.textBox_nameIzd_Click);
            // 
            // tabPage_Zakazs
            // 
            this.tabPage_Zakazs.Controls.Add(this.dgv_ZakazMain);
            this.tabPage_Zakazs.Controls.Add(this.radioButton_readyZakaz);
            this.tabPage_Zakazs.Controls.Add(this.radioButton_loadZakaz);
            this.tabPage_Zakazs.Controls.Add(this.radioButton_newZakaz);
            this.tabPage_Zakazs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage_Zakazs.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Zakazs.Name = "tabPage_Zakazs";
            this.tabPage_Zakazs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Zakazs.Size = new System.Drawing.Size(973, 583);
            this.tabPage_Zakazs.TabIndex = 0;
            this.tabPage_Zakazs.Text = "Заказы";
            this.tabPage_Zakazs.UseVisualStyleBackColor = true;
            this.tabPage_Zakazs.Enter += new System.EventHandler(this.tabPage_Zakazs_Enter);
            // 
            // dgv_ZakazMain
            // 
            this.dgv_ZakazMain.AllowUserToAddRows = false;
            this.dgv_ZakazMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ZakazMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ZakazMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ZakazMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column_Date,
            this.Column_Izdel,
            this.Column_Client,
            this.Column_ContactInfo,
            this.Column_Price});
            this.dgv_ZakazMain.Location = new System.Drawing.Point(19, 221);
            this.dgv_ZakazMain.Name = "dgv_ZakazMain";
            this.dgv_ZakazMain.ReadOnly = true;
            this.dgv_ZakazMain.Size = new System.Drawing.Size(931, 348);
            this.dgv_ZakazMain.TabIndex = 3;
            this.dgv_ZakazMain.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dqv_ZakazMain_RowHeaderMouseDoubleClick);
            // 
            // id
            // 
            this.id.FillWeight = 15.22843F;
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Column_Date
            // 
            this.Column_Date.FillWeight = 116.9543F;
            this.Column_Date.HeaderText = "Дата";
            this.Column_Date.Name = "Column_Date";
            this.Column_Date.ReadOnly = true;
            // 
            // Column_Izdel
            // 
            this.Column_Izdel.FillWeight = 116.9543F;
            this.Column_Izdel.HeaderText = "Изделие";
            this.Column_Izdel.Name = "Column_Izdel";
            this.Column_Izdel.ReadOnly = true;
            // 
            // Column_Client
            // 
            this.Column_Client.FillWeight = 116.9543F;
            this.Column_Client.HeaderText = "Клиент";
            this.Column_Client.Name = "Column_Client";
            this.Column_Client.ReadOnly = true;
            // 
            // Column_ContactInfo
            // 
            this.Column_ContactInfo.FillWeight = 116.9543F;
            this.Column_ContactInfo.HeaderText = "Контактная инфо.";
            this.Column_ContactInfo.Name = "Column_ContactInfo";
            this.Column_ContactInfo.ReadOnly = true;
            // 
            // Column_Price
            // 
            this.Column_Price.FillWeight = 116.9543F;
            this.Column_Price.HeaderText = "Цена, P";
            this.Column_Price.Name = "Column_Price";
            this.Column_Price.ReadOnly = true;
            // 
            // radioButton_readyZakaz
            // 
            this.radioButton_readyZakaz.AutoSize = true;
            this.radioButton_readyZakaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_readyZakaz.Location = new System.Drawing.Point(35, 124);
            this.radioButton_readyZakaz.Name = "radioButton_readyZakaz";
            this.radioButton_readyZakaz.Size = new System.Drawing.Size(149, 24);
            this.radioButton_readyZakaz.TabIndex = 2;
            this.radioButton_readyZakaz.Text = "Готовые заказы";
            this.radioButton_readyZakaz.UseVisualStyleBackColor = true;
            this.radioButton_readyZakaz.CheckedChanged += new System.EventHandler(this.radioButton_readyZakaz_CheckedChanged);
            // 
            // radioButton_loadZakaz
            // 
            this.radioButton_loadZakaz.AutoSize = true;
            this.radioButton_loadZakaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_loadZakaz.Location = new System.Drawing.Point(35, 83);
            this.radioButton_loadZakaz.Name = "radioButton_loadZakaz";
            this.radioButton_loadZakaz.Size = new System.Drawing.Size(212, 24);
            this.radioButton_loadZakaz.TabIndex = 1;
            this.radioButton_loadZakaz.Text = "Выполняющиеся заказы";
            this.radioButton_loadZakaz.UseVisualStyleBackColor = true;
            this.radioButton_loadZakaz.CheckedChanged += new System.EventHandler(this.radioButton_loadZakaz_CheckedChanged);
            // 
            // radioButton_newZakaz
            // 
            this.radioButton_newZakaz.AutoSize = true;
            this.radioButton_newZakaz.Checked = true;
            this.radioButton_newZakaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_newZakaz.Location = new System.Drawing.Point(35, 37);
            this.radioButton_newZakaz.Name = "radioButton_newZakaz";
            this.radioButton_newZakaz.Size = new System.Drawing.Size(134, 24);
            this.radioButton_newZakaz.TabIndex = 0;
            this.radioButton_newZakaz.TabStop = true;
            this.radioButton_newZakaz.Text = "Новые заказы";
            this.radioButton_newZakaz.UseVisualStyleBackColor = true;
            this.radioButton_newZakaz.CheckedChanged += new System.EventHandler(this.radioButton_newZakaz_CheckedChanged);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Zakazs);
            this.tabControl_Main.Controls.Add(this.tabPage_DataMain);
            this.tabControl_Main.Controls.Add(this.tabPage_sotrudnik);
            this.tabControl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl_Main.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(981, 616);
            this.tabControl_Main.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 640);
            this.Controls.Add(this.tabControl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jewerlyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdeliesprBindingSource)).EndInit();
            this.tabPage_sotrudnik.ResumeLayout(false);
            this.tabPage_sotrudnik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Stag)).EndInit();
            this.tabPage_DataMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Mats)).EndInit();
            this.tabPage_izdSpr.ResumeLayout(false);
            this.tabPage_izdSpr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Izd)).EndInit();
            this.tabPage_Zakazs.ResumeLayout(false);
            this.tabPage_Zakazs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ZakazMain)).EndInit();
            this.tabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private jewerlyDataSet jewerlyDataSet;
        private System.Windows.Forms.BindingSource izdeliesprBindingSource;
        private jewerlyDataSetTableAdapters.izdelie_sprTableAdapter izdelie_sprTableAdapter;
        private System.Windows.Forms.TabPage tabPage_sotrudnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.TabPage tabPage_DataMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dvg_Mats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PriceOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_bank;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TabPage tabPage_izdSpr;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.PictureBox pictureBox_Izd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_rabota;
        private System.Windows.Forms.Label label_nameItm;
        private System.Windows.Forms.TextBox textBox_nameweb;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.TextBox textBox_urlIzd;
        private System.Windows.Forms.ComboBox comboBox_tipIzd;
        private System.Windows.Forms.Label label_tipIzd;
        private System.Windows.Forms.ComboBox comboBox_mats;
        private System.Windows.Forms.Label label_mats;
        private System.Windows.Forms.Label label_nameIzd;
        private System.Windows.Forms.TextBox textBox_nameIzd;
        private System.Windows.Forms.TabPage tabPage_Zakazs;
        private System.Windows.Forms.DataGridView dgv_ZakazMain;
        private System.Windows.Forms.RadioButton radioButton_readyZakaz;
        private System.Windows.Forms.RadioButton radioButton_loadZakaz;
        private System.Windows.Forms.RadioButton radioButton_newZakaz;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_downmaster;
        private System.Windows.Forms.Button button_upmaster;
        private System.Windows.Forms.NumericUpDown numericUpDown_Stag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_savemaster;
        private System.Windows.Forms.Button button_addmaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Izdel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ContactInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
    }
}

