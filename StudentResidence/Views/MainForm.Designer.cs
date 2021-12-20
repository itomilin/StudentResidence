
namespace StudentResidence.Views
{
    partial class MainForm
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
            this.groupClean = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCleanup = new System.Windows.Forms.Button();
            this.numCleanup = new System.Windows.Forms.NumericUpDown();
            this.groupMove = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.numMove = new System.Windows.Forms.NumericUpDown();
            this.cbStudents = new System.Windows.Forms.ComboBox();
            this.btnShowFree = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.numSearch = new System.Windows.Forms.NumericUpDown();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.rbFindByBirthDay = new System.Windows.Forms.RadioButton();
            this.rbFindBySurname = new System.Windows.Forms.RadioButton();
            this.rbFindByRoom = new System.Windows.Forms.RadioButton();
            this.rbFindByCourse = new System.Windows.Forms.RadioButton();
            this.rbFindByGroup = new System.Windows.Forms.RadioButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.groupManage = new System.Windows.Forms.GroupBox();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.saveBackupDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupClean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCleanup)).BeginInit();
            this.groupMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMove)).BeginInit();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupClean
            // 
            this.groupClean.Controls.Add(this.label1);
            this.groupClean.Controls.Add(this.btnCleanup);
            this.groupClean.Controls.Add(this.numCleanup);
            this.groupClean.Location = new System.Drawing.Point(9, 19);
            this.groupClean.Name = "groupClean";
            this.groupClean.Size = new System.Drawing.Size(207, 119);
            this.groupClean.TabIndex = 24;
            this.groupClean.TabStop = false;
            this.groupClean.Text = "Очистка комнаты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID комнаты:";
            // 
            // btnCleanup
            // 
            this.btnCleanup.Location = new System.Drawing.Point(10, 70);
            this.btnCleanup.Name = "btnCleanup";
            this.btnCleanup.Size = new System.Drawing.Size(185, 43);
            this.btnCleanup.TabIndex = 19;
            this.btnCleanup.Text = "Выполнить очистку";
            this.btnCleanup.UseVisualStyleBackColor = true;
            // 
            // numCleanup
            // 
            this.numCleanup.Location = new System.Drawing.Point(114, 22);
            this.numCleanup.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCleanup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCleanup.Name = "numCleanup";
            this.numCleanup.Size = new System.Drawing.Size(87, 29);
            this.numCleanup.TabIndex = 23;
            this.numCleanup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupMove
            // 
            this.groupMove.Controls.Add(this.label3);
            this.groupMove.Controls.Add(this.label2);
            this.groupMove.Controls.Add(this.btnMove);
            this.groupMove.Controls.Add(this.numMove);
            this.groupMove.Controls.Add(this.cbStudents);
            this.groupMove.Location = new System.Drawing.Point(9, 207);
            this.groupMove.Name = "groupMove";
            this.groupMove.Size = new System.Drawing.Size(344, 137);
            this.groupMove.TabIndex = 9;
            this.groupMove.TabStop = false;
            this.groupMove.Text = "Перемещение студента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "ID студента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID комнаты куда перемещаем:";
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.Location = new System.Drawing.Point(10, 88);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(328, 43);
            this.btnMove.TabIndex = 20;
            this.btnMove.Text = "Переместить";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // numMove
            // 
            this.numMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMove.Location = new System.Drawing.Point(239, 18);
            this.numMove.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMove.Name = "numMove";
            this.numMove.Size = new System.Drawing.Size(99, 29);
            this.numMove.TabIndex = 23;
            this.numMove.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbStudents
            // 
            this.cbStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudents.FormattingEnabled = true;
            this.cbStudents.Location = new System.Drawing.Point(239, 53);
            this.cbStudents.Name = "cbStudents";
            this.cbStudents.Size = new System.Drawing.Size(98, 29);
            this.cbStudents.TabIndex = 22;
            // 
            // btnShowFree
            // 
            this.btnShowFree.Location = new System.Drawing.Point(222, 142);
            this.btnShowFree.Name = "btnShowFree";
            this.btnShowFree.Size = new System.Drawing.Size(138, 43);
            this.btnShowFree.TabIndex = 8;
            this.btnShowFree.Text = "Пустые комнаты";
            this.btnShowFree.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(222, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbTables
            // 
            this.cbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTables.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Items.AddRange(new object[] {
            "Студенты",
            "Комнаты",
            "Комнаты-Студенты"});
            this.cbTables.Location = new System.Drawing.Point(222, 19);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(138, 29);
            this.cbTables.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(222, 50);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(138, 43);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // groupSearch
            // 
            this.groupSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSearch.BackColor = System.Drawing.Color.Transparent;
            this.groupSearch.Controls.Add(this.btnFind);
            this.groupSearch.Controls.Add(this.numSearch);
            this.groupSearch.Controls.Add(this.dtpBirth);
            this.groupSearch.Controls.Add(this.tbSearch);
            this.groupSearch.Controls.Add(this.rbFindByBirthDay);
            this.groupSearch.Controls.Add(this.rbFindBySurname);
            this.groupSearch.Controls.Add(this.rbFindByRoom);
            this.groupSearch.Controls.Add(this.rbFindByCourse);
            this.groupSearch.Controls.Add(this.rbFindByGroup);
            this.groupSearch.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearch.Location = new System.Drawing.Point(12, 137);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(375, 201);
            this.groupSearch.TabIndex = 11;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Поиск студентов по критериям";
            this.groupSearch.Visible = false;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(9, 134);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(225, 43);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Поиск";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // numSearch
            // 
            this.numSearch.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSearch.Location = new System.Drawing.Point(9, 99);
            this.numSearch.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSearch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSearch.Name = "numSearch";
            this.numSearch.Size = new System.Drawing.Size(225, 29);
            this.numSearch.TabIndex = 18;
            this.numSearch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSearch.Visible = false;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBirth.Location = new System.Drawing.Point(9, 99);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(224, 29);
            this.dtpBirth.TabIndex = 17;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(9, 99);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(224, 29);
            this.tbSearch.TabIndex = 16;
            this.tbSearch.Visible = false;
            // 
            // rbFindByBirthDay
            // 
            this.rbFindByBirthDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFindByBirthDay.AutoSize = true;
            this.rbFindByBirthDay.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFindByBirthDay.Location = new System.Drawing.Point(167, 42);
            this.rbFindByBirthDay.Name = "rbFindByBirthDay";
            this.rbFindByBirthDay.Size = new System.Drawing.Size(206, 25);
            this.rbFindByBirthDay.TabIndex = 15;
            this.rbFindByBirthDay.Text = "Найти по дате рождения";
            this.rbFindByBirthDay.UseVisualStyleBackColor = true;
            // 
            // rbFindBySurname
            // 
            this.rbFindBySurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFindBySurname.AutoSize = true;
            this.rbFindBySurname.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFindBySurname.Location = new System.Drawing.Point(6, 42);
            this.rbFindBySurname.Name = "rbFindBySurname";
            this.rbFindBySurname.Size = new System.Drawing.Size(164, 25);
            this.rbFindBySurname.TabIndex = 14;
            this.rbFindBySurname.Text = "Найти по фамилии";
            this.rbFindBySurname.UseVisualStyleBackColor = true;
            // 
            // rbFindByRoom
            // 
            this.rbFindByRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFindByRoom.AutoSize = true;
            this.rbFindByRoom.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFindByRoom.Location = new System.Drawing.Point(167, 65);
            this.rbFindByRoom.Name = "rbFindByRoom";
            this.rbFindByRoom.Size = new System.Drawing.Size(158, 25);
            this.rbFindByRoom.TabIndex = 13;
            this.rbFindByRoom.Text = "Найти по комнате";
            this.rbFindByRoom.UseVisualStyleBackColor = true;
            // 
            // rbFindByCourse
            // 
            this.rbFindByCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFindByCourse.AutoSize = true;
            this.rbFindByCourse.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFindByCourse.Location = new System.Drawing.Point(167, 19);
            this.rbFindByCourse.Name = "rbFindByCourse";
            this.rbFindByCourse.Size = new System.Drawing.Size(137, 25);
            this.rbFindByCourse.TabIndex = 12;
            this.rbFindByCourse.Text = "Найти по курсу";
            this.rbFindByCourse.UseVisualStyleBackColor = true;
            // 
            // rbFindByGroup
            // 
            this.rbFindByGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFindByGroup.AutoSize = true;
            this.rbFindByGroup.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFindByGroup.Location = new System.Drawing.Point(6, 19);
            this.rbFindByGroup.Name = "rbFindByGroup";
            this.rbFindByGroup.Size = new System.Drawing.Size(144, 25);
            this.rbFindByGroup.TabIndex = 11;
            this.rbFindByGroup.Text = "Найти по группе";
            this.rbFindByGroup.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(403, 238);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grid.Size = new System.Drawing.Size(669, 252);
            this.grid.TabIndex = 1;
            // 
            // groupManage
            // 
            this.groupManage.BackColor = System.Drawing.Color.Transparent;
            this.groupManage.Controls.Add(this.cbTables);
            this.groupManage.Controls.Add(this.groupClean);
            this.groupManage.Controls.Add(this.groupMove);
            this.groupManage.Controls.Add(this.btnShowFree);
            this.groupManage.Controls.Add(this.btnDelete);
            this.groupManage.Controls.Add(this.btnInsert);
            this.groupManage.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupManage.Location = new System.Drawing.Point(12, 137);
            this.groupManage.Name = "groupManage";
            this.groupManage.Size = new System.Drawing.Size(375, 353);
            this.groupManage.TabIndex = 25;
            this.groupManage.TabStop = false;
            this.groupManage.Text = "Управление";
            this.groupManage.Visible = false;
            // 
            // btnManage
            // 
            this.btnManage.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.Location = new System.Drawing.Point(12, 12);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(204, 82);
            this.btnManage.TabIndex = 26;
            this.btnManage.Text = "УПРАВЛЕНИЕ";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(222, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(204, 82);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "ПОИСК";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(432, 12);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(204, 82);
            this.btnBackup.TabIndex = 28;
            this.btnBackup.Text = "РЕЗЕРВНОЕ КОПИРОВАНИЕ";
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentResidence.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(1084, 493);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupClean.ResumeLayout(false);
            this.groupClean.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCleanup)).EndInit();
            this.groupMove.ResumeLayout(false);
            this.groupMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMove)).EndInit();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.RadioButton rbFindBySurname;
        private System.Windows.Forms.RadioButton rbFindByRoom;
        private System.Windows.Forms.RadioButton rbFindByCourse;
        private System.Windows.Forms.RadioButton rbFindByGroup;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RadioButton rbFindByBirthDay;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.NumericUpDown numSearch;
        private System.Windows.Forms.GroupBox groupMove;
        private System.Windows.Forms.NumericUpDown numMove;
        private System.Windows.Forms.ComboBox cbStudents;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.GroupBox groupClean;
        private System.Windows.Forms.Button btnCleanup;
        private System.Windows.Forms.NumericUpDown numCleanup;
        private System.Windows.Forms.Button btnShowFree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupManage;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.SaveFileDialog saveBackupDialog;
    }
}

