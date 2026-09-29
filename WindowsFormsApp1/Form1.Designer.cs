namespace WindowsFormsApp1
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
            this.microsoft_Access_База_данныхDataSet = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSet();
            this.microsoftAccessБазаданныхDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSetTableAdapters.ПользователиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idПользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idПродавцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idПользователяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейтингDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПродажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продавцыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idАккаунтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idПродавцаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аккаунтыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idСделкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idПокупателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idПродавцаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idАккаунтаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСделкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сделкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idСделкиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оплатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.idЗаморозкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idОплатыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаморозкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.замораживаниеСредствBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.idПодтвержденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idСделкиDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПодтвержденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.подтверждениеОплатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.idСпораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idСделкиDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.причинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.решениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idАдминистратораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спорыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.idАдминистратораDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.администраторыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продавцыTableAdapter = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSetTableAdapters.ПродавцыTableAdapter();
            this.аккаунтыTableAdapter = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSetTableAdapters.АккаунтыTableAdapter();
            this.сделкиTableAdapter = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSetTableAdapters.СделкиTableAdapter();
            this.оплатаTableAdapter = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSetTableAdapters.ОплатаTableAdapter();
            this.замораживание_средствTableAdapter = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSetTableAdapters.Замораживание_средствTableAdapter();
            this.подтверждение_оплатыTableAdapter = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSetTableAdapters.Подтверждение_оплатыTableAdapter();
            this.спорыTableAdapter = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSetTableAdapters.СпорыTableAdapter();
            this.администраторыTableAdapter = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSetTableAdapters.АдминистраторыTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoftAccessБазаданныхDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продавцыBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аккаунтыBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделкиBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.замораживаниеСредствBindingSource)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подтверждениеОплатыBindingSource)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спорыBindingSource)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.администраторыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // microsoft_Access_База_данныхDataSet
            // 
            this.microsoft_Access_База_данныхDataSet.DataSetName = "Microsoft_Access_База_данныхDataSet";
            this.microsoft_Access_База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // microsoftAccessБазаданныхDataSetBindingSource
            // 
            this.microsoftAccessБазаданныхDataSetBindingSource.DataSource = this.microsoft_Access_База_данныхDataSet;
            this.microsoftAccessБазаданныхDataSetBindingSource.Position = 0;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.microsoftAccessБазаданныхDataSetBindingSource;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Сохранить_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 398);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idПользователяDataGridViewTextBoxColumn,
            this.логинDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.датаРегистрацииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.пользователиBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 366);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idПользователяDataGridViewTextBoxColumn
            // 
            this.idПользователяDataGridViewTextBoxColumn.DataPropertyName = "id пользователя";
            this.idПользователяDataGridViewTextBoxColumn.HeaderText = "id пользователя";
            this.idПользователяDataGridViewTextBoxColumn.Name = "idПользователяDataGridViewTextBoxColumn";
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // датаРегистрацииDataGridViewTextBoxColumn
            // 
            this.датаРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn.HeaderText = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn.Name = "датаРегистрацииDataGridViewTextBoxColumn";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продавцы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idПродавцаDataGridViewTextBoxColumn,
            this.idПользователяDataGridViewTextBoxColumn1,
            this.рейтингDataGridViewTextBoxColumn,
            this.количествоПродажDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.продавцыBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(762, 366);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // idПродавцаDataGridViewTextBoxColumn
            // 
            this.idПродавцаDataGridViewTextBoxColumn.DataPropertyName = "id продавца";
            this.idПродавцаDataGridViewTextBoxColumn.HeaderText = "id продавца";
            this.idПродавцаDataGridViewTextBoxColumn.Name = "idПродавцаDataGridViewTextBoxColumn";
            // 
            // idПользователяDataGridViewTextBoxColumn1
            // 
            this.idПользователяDataGridViewTextBoxColumn1.DataPropertyName = "id пользователя";
            this.idПользователяDataGridViewTextBoxColumn1.HeaderText = "id пользователя";
            this.idПользователяDataGridViewTextBoxColumn1.Name = "idПользователяDataGridViewTextBoxColumn1";
            // 
            // рейтингDataGridViewTextBoxColumn
            // 
            this.рейтингDataGridViewTextBoxColumn.DataPropertyName = "Рейтинг";
            this.рейтингDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.рейтингDataGridViewTextBoxColumn.Name = "рейтингDataGridViewTextBoxColumn";
            // 
            // количествоПродажDataGridViewTextBoxColumn
            // 
            this.количествоПродажDataGridViewTextBoxColumn.DataPropertyName = "Количество продаж";
            this.количествоПродажDataGridViewTextBoxColumn.HeaderText = "Количество продаж";
            this.количествоПродажDataGridViewTextBoxColumn.Name = "количествоПродажDataGridViewTextBoxColumn";
            // 
            // продавцыBindingSource
            // 
            this.продавцыBindingSource.DataMember = "Продавцы";
            this.продавцыBindingSource.DataSource = this.microsoftAccessБазаданныхDataSetBindingSource;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Аккаунты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idАккаунтаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.idПродавцаDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.аккаунтыBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(762, 366);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
            // 
            // idАккаунтаDataGridViewTextBoxColumn
            // 
            this.idАккаунтаDataGridViewTextBoxColumn.DataPropertyName = "id аккаунта";
            this.idАккаунтаDataGridViewTextBoxColumn.HeaderText = "id аккаунта";
            this.idАккаунтаDataGridViewTextBoxColumn.Name = "idАккаунтаDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // idПродавцаDataGridViewTextBoxColumn1
            // 
            this.idПродавцаDataGridViewTextBoxColumn1.DataPropertyName = "id продавца";
            this.idПродавцаDataGridViewTextBoxColumn1.HeaderText = "id продавца";
            this.idПродавцаDataGridViewTextBoxColumn1.Name = "idПродавцаDataGridViewTextBoxColumn1";
            // 
            // аккаунтыBindingSource
            // 
            this.аккаунтыBindingSource.DataMember = "Аккаунты";
            this.аккаунтыBindingSource.DataSource = this.microsoftAccessБазаданныхDataSetBindingSource;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 372);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Сделки";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idСделкиDataGridViewTextBoxColumn,
            this.idПокупателяDataGridViewTextBoxColumn,
            this.idПродавцаDataGridViewTextBoxColumn2,
            this.idАккаунтаDataGridViewTextBoxColumn1,
            this.датаСделкиDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.сделкиBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(762, 366);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView4_UserDeletingRow);
            // 
            // idСделкиDataGridViewTextBoxColumn
            // 
            this.idСделкиDataGridViewTextBoxColumn.DataPropertyName = "id сделки";
            this.idСделкиDataGridViewTextBoxColumn.HeaderText = "id сделки";
            this.idСделкиDataGridViewTextBoxColumn.Name = "idСделкиDataGridViewTextBoxColumn";
            // 
            // idПокупателяDataGridViewTextBoxColumn
            // 
            this.idПокупателяDataGridViewTextBoxColumn.DataPropertyName = "id покупателя";
            this.idПокупателяDataGridViewTextBoxColumn.HeaderText = "id покупателя";
            this.idПокупателяDataGridViewTextBoxColumn.Name = "idПокупателяDataGridViewTextBoxColumn";
            // 
            // idПродавцаDataGridViewTextBoxColumn2
            // 
            this.idПродавцаDataGridViewTextBoxColumn2.DataPropertyName = "id продавца";
            this.idПродавцаDataGridViewTextBoxColumn2.HeaderText = "id продавца";
            this.idПродавцаDataGridViewTextBoxColumn2.Name = "idПродавцаDataGridViewTextBoxColumn2";
            // 
            // idАккаунтаDataGridViewTextBoxColumn1
            // 
            this.idАккаунтаDataGridViewTextBoxColumn1.DataPropertyName = "id аккаунта";
            this.idАккаунтаDataGridViewTextBoxColumn1.HeaderText = "id аккаунта";
            this.idАккаунтаDataGridViewTextBoxColumn1.Name = "idАккаунтаDataGridViewTextBoxColumn1";
            // 
            // датаСделкиDataGridViewTextBoxColumn
            // 
            this.датаСделкиDataGridViewTextBoxColumn.DataPropertyName = "Дата сделки";
            this.датаСделкиDataGridViewTextBoxColumn.HeaderText = "Дата сделки";
            this.датаСделкиDataGridViewTextBoxColumn.Name = "датаСделкиDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // сделкиBindingSource
            // 
            this.сделкиBindingSource.DataMember = "Сделки";
            this.сделкиBindingSource.DataSource = this.microsoftAccessБазаданныхDataSetBindingSource;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 372);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Оплаты";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idОплатыDataGridViewTextBoxColumn,
            this.idСделкиDataGridViewTextBoxColumn1,
            this.суммаDataGridViewTextBoxColumn,
            this.датаОплатыDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.оплатаBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(762, 366);
            this.dataGridView5.TabIndex = 0;
            this.dataGridView5.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView5_UserDeletingRow);
            // 
            // idОплатыDataGridViewTextBoxColumn
            // 
            this.idОплатыDataGridViewTextBoxColumn.DataPropertyName = "id оплаты";
            this.idОплатыDataGridViewTextBoxColumn.HeaderText = "id оплаты";
            this.idОплатыDataGridViewTextBoxColumn.Name = "idОплатыDataGridViewTextBoxColumn";
            // 
            // idСделкиDataGridViewTextBoxColumn1
            // 
            this.idСделкиDataGridViewTextBoxColumn1.DataPropertyName = "id сделки";
            this.idСделкиDataGridViewTextBoxColumn1.HeaderText = "id сделки";
            this.idСделкиDataGridViewTextBoxColumn1.Name = "idСделкиDataGridViewTextBoxColumn1";
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            // 
            // датаОплатыDataGridViewTextBoxColumn
            // 
            this.датаОплатыDataGridViewTextBoxColumn.DataPropertyName = "Дата оплаты";
            this.датаОплатыDataGridViewTextBoxColumn.HeaderText = "Дата оплаты";
            this.датаОплатыDataGridViewTextBoxColumn.Name = "датаОплатыDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn1
            // 
            this.статусDataGridViewTextBoxColumn1.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn1.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn1.Name = "статусDataGridViewTextBoxColumn1";
            // 
            // оплатаBindingSource
            // 
            this.оплатаBindingSource.DataMember = "Оплата";
            this.оплатаBindingSource.DataSource = this.microsoftAccessБазаданныхDataSetBindingSource;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(768, 372);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Замораживание средств";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idЗаморозкиDataGridViewTextBoxColumn,
            this.idОплатыDataGridViewTextBoxColumn1,
            this.суммаDataGridViewTextBoxColumn1,
            this.датаЗаморозкиDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn2});
            this.dataGridView6.DataSource = this.замораживаниеСредствBindingSource;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(762, 366);
            this.dataGridView6.TabIndex = 0;
            this.dataGridView6.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView6_UserDeletingRow);
            // 
            // idЗаморозкиDataGridViewTextBoxColumn
            // 
            this.idЗаморозкиDataGridViewTextBoxColumn.DataPropertyName = "id заморозки";
            this.idЗаморозкиDataGridViewTextBoxColumn.HeaderText = "id заморозки";
            this.idЗаморозкиDataGridViewTextBoxColumn.Name = "idЗаморозкиDataGridViewTextBoxColumn";
            // 
            // idОплатыDataGridViewTextBoxColumn1
            // 
            this.idОплатыDataGridViewTextBoxColumn1.DataPropertyName = "id оплаты";
            this.idОплатыDataGridViewTextBoxColumn1.HeaderText = "id оплаты";
            this.idОплатыDataGridViewTextBoxColumn1.Name = "idОплатыDataGridViewTextBoxColumn1";
            // 
            // суммаDataGridViewTextBoxColumn1
            // 
            this.суммаDataGridViewTextBoxColumn1.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn1.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn1.Name = "суммаDataGridViewTextBoxColumn1";
            // 
            // датаЗаморозкиDataGridViewTextBoxColumn
            // 
            this.датаЗаморозкиDataGridViewTextBoxColumn.DataPropertyName = "Дата заморозки";
            this.датаЗаморозкиDataGridViewTextBoxColumn.HeaderText = "Дата заморозки";
            this.датаЗаморозкиDataGridViewTextBoxColumn.Name = "датаЗаморозкиDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn2
            // 
            this.статусDataGridViewTextBoxColumn2.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn2.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn2.Name = "статусDataGridViewTextBoxColumn2";
            // 
            // замораживаниеСредствBindingSource
            // 
            this.замораживаниеСредствBindingSource.DataMember = "Замораживание средств";
            this.замораживаниеСредствBindingSource.DataSource = this.microsoftAccessБазаданныхDataSetBindingSource;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridView7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(768, 372);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Подтвержденые оплаты";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idПодтвержденияDataGridViewTextBoxColumn,
            this.idСделкиDataGridViewTextBoxColumn2,
            this.датаПодтвержденияDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn3});
            this.dataGridView7.DataSource = this.подтверждениеОплатыBindingSource;
            this.dataGridView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView7.Location = new System.Drawing.Point(3, 3);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(762, 366);
            this.dataGridView7.TabIndex = 0;
            this.dataGridView7.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView7_UserDeletingRow);
            // 
            // idПодтвержденияDataGridViewTextBoxColumn
            // 
            this.idПодтвержденияDataGridViewTextBoxColumn.DataPropertyName = "id подтверждения";
            this.idПодтвержденияDataGridViewTextBoxColumn.HeaderText = "id подтверждения";
            this.idПодтвержденияDataGridViewTextBoxColumn.Name = "idПодтвержденияDataGridViewTextBoxColumn";
            // 
            // idСделкиDataGridViewTextBoxColumn2
            // 
            this.idСделкиDataGridViewTextBoxColumn2.DataPropertyName = "id сделки";
            this.idСделкиDataGridViewTextBoxColumn2.HeaderText = "id сделки";
            this.idСделкиDataGridViewTextBoxColumn2.Name = "idСделкиDataGridViewTextBoxColumn2";
            // 
            // датаПодтвержденияDataGridViewTextBoxColumn
            // 
            this.датаПодтвержденияDataGridViewTextBoxColumn.DataPropertyName = "Дата подтверждения";
            this.датаПодтвержденияDataGridViewTextBoxColumn.HeaderText = "Дата подтверждения";
            this.датаПодтвержденияDataGridViewTextBoxColumn.Name = "датаПодтвержденияDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn3
            // 
            this.статусDataGridViewTextBoxColumn3.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn3.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn3.Name = "статусDataGridViewTextBoxColumn3";
            // 
            // подтверждениеОплатыBindingSource
            // 
            this.подтверждениеОплатыBindingSource.DataMember = "Подтверждение оплаты";
            this.подтверждениеОплатыBindingSource.DataSource = this.microsoftAccessБазаданныхDataSetBindingSource;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dataGridView8);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(768, 372);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Споры";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            this.dataGridView8.AutoGenerateColumns = false;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idСпораDataGridViewTextBoxColumn,
            this.idСделкиDataGridViewTextBoxColumn3,
            this.причинаDataGridViewTextBoxColumn,
            this.решениеDataGridViewTextBoxColumn,
            this.idАдминистратораDataGridViewTextBoxColumn});
            this.dataGridView8.DataSource = this.спорыBindingSource;
            this.dataGridView8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView8.Location = new System.Drawing.Point(3, 3);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.Size = new System.Drawing.Size(762, 366);
            this.dataGridView8.TabIndex = 0;
            this.dataGridView8.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView8_UserDeletingRow);
            // 
            // idСпораDataGridViewTextBoxColumn
            // 
            this.idСпораDataGridViewTextBoxColumn.DataPropertyName = "id спора";
            this.idСпораDataGridViewTextBoxColumn.HeaderText = "id спора";
            this.idСпораDataGridViewTextBoxColumn.Name = "idСпораDataGridViewTextBoxColumn";
            // 
            // idСделкиDataGridViewTextBoxColumn3
            // 
            this.idСделкиDataGridViewTextBoxColumn3.DataPropertyName = "id сделки";
            this.idСделкиDataGridViewTextBoxColumn3.HeaderText = "id сделки";
            this.idСделкиDataGridViewTextBoxColumn3.Name = "idСделкиDataGridViewTextBoxColumn3";
            // 
            // причинаDataGridViewTextBoxColumn
            // 
            this.причинаDataGridViewTextBoxColumn.DataPropertyName = "Причина";
            this.причинаDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.причинаDataGridViewTextBoxColumn.Name = "причинаDataGridViewTextBoxColumn";
            // 
            // решениеDataGridViewTextBoxColumn
            // 
            this.решениеDataGridViewTextBoxColumn.DataPropertyName = "Решение";
            this.решениеDataGridViewTextBoxColumn.HeaderText = "Решение";
            this.решениеDataGridViewTextBoxColumn.Name = "решениеDataGridViewTextBoxColumn";
            // 
            // idАдминистратораDataGridViewTextBoxColumn
            // 
            this.idАдминистратораDataGridViewTextBoxColumn.DataPropertyName = "id администратора";
            this.idАдминистратораDataGridViewTextBoxColumn.HeaderText = "id администратора";
            this.idАдминистратораDataGridViewTextBoxColumn.Name = "idАдминистратораDataGridViewTextBoxColumn";
            // 
            // спорыBindingSource
            // 
            this.спорыBindingSource.DataMember = "Споры";
            this.спорыBindingSource.DataSource = this.microsoftAccessБазаданныхDataSetBindingSource;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.dataGridView9);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(768, 372);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Администраторы";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // dataGridView9
            // 
            this.dataGridView9.AutoGenerateColumns = false;
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idАдминистратораDataGridViewTextBoxColumn1,
            this.логинDataGridViewTextBoxColumn1,
            this.парольDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn});
            this.dataGridView9.DataSource = this.администраторыBindingSource;
            this.dataGridView9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView9.Location = new System.Drawing.Point(3, 3);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.Size = new System.Drawing.Size(762, 366);
            this.dataGridView9.TabIndex = 0;
            this.dataGridView9.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView9_UserDeletingRow);
            // 
            // idАдминистратораDataGridViewTextBoxColumn1
            // 
            this.idАдминистратораDataGridViewTextBoxColumn1.DataPropertyName = "id администратора";
            this.idАдминистратораDataGridViewTextBoxColumn1.HeaderText = "id администратора";
            this.idАдминистратораDataGridViewTextBoxColumn1.Name = "idАдминистратораDataGridViewTextBoxColumn1";
            // 
            // логинDataGridViewTextBoxColumn1
            // 
            this.логинDataGridViewTextBoxColumn1.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn1.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn1.Name = "логинDataGridViewTextBoxColumn1";
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // администраторыBindingSource
            // 
            this.администраторыBindingSource.DataMember = "Администраторы";
            this.администраторыBindingSource.DataSource = this.microsoftAccessБазаданныхDataSetBindingSource;
            // 
            // продавцыTableAdapter
            // 
            this.продавцыTableAdapter.ClearBeforeFill = true;
            // 
            // аккаунтыTableAdapter
            // 
            this.аккаунтыTableAdapter.ClearBeforeFill = true;
            // 
            // сделкиTableAdapter
            // 
            this.сделкиTableAdapter.ClearBeforeFill = true;
            // 
            // оплатаTableAdapter
            // 
            this.оплатаTableAdapter.ClearBeforeFill = true;
            // 
            // замораживание_средствTableAdapter
            // 
            this.замораживание_средствTableAdapter.ClearBeforeFill = true;
            // 
            // подтверждение_оплатыTableAdapter
            // 
            this.подтверждение_оплатыTableAdapter.ClearBeforeFill = true;
            // 
            // спорыTableAdapter
            // 
            this.спорыTableAdapter.ClearBeforeFill = true;
            // 
            // администраторыTableAdapter
            // 
            this.администраторыTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 438);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "FunPay";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoftAccessБазаданныхDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продавцыBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аккаунтыBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сделкиBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.замораживаниеСредствBindingSource)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подтверждениеОплатыBindingSource)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спорыBindingSource)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.администраторыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource microsoftAccessБазаданныхDataSetBindingSource;
        private Microsoft_Access_База_данныхDataSet microsoft_Access_База_данныхDataSet;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idПользователяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource продавцыBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.ПродавцыTableAdapter продавцыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idПродавцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idПользователяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn рейтингDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПродажDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.BindingSource аккаунтыBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.АккаунтыTableAdapter аккаунтыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idАккаунтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idПродавцаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource сделкиBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.СделкиTableAdapter сделкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСделкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idПокупателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idПродавцаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idАккаунтаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСделкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource оплатаBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.ОплатаTableAdapter оплатаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idОплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСделкиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource замораживаниеСредствBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.Замораживание_средствTableAdapter замораживание_средствTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗаморозкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idОплатыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаморозкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.BindingSource подтверждениеОплатыBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.Подтверждение_оплатыTableAdapter подтверждение_оплатыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idПодтвержденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСделкиDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПодтвержденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource спорыBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.СпорыTableAdapter спорыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСпораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСделкиDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn причинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn решениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idАдминистратораDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.BindingSource администраторыBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.АдминистраторыTableAdapter администраторыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idАдминистратораDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
    }
}

