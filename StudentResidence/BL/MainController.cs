using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using StudentResidence.Views;

namespace StudentResidence.BL
{
    partial class MainController
    {
        // поле для хранения состояния выбора текущей таблицы
        private string _currentTableName;

        // поля для хранения информации/ссылок о представлениях 
        private readonly MainForm _mainForm;
        private readonly StudentForm _studentForm;
        private readonly RoomForm _roomForm;
        private readonly StudentRoomForm _studentRoomForm;

        // конструктор, выполняем подписку на события представления
        public MainController(MainForm mainForm, params Form[] modalForms)
        {
            _mainForm = mainForm;

            _mainForm.Backup.Click += Backup;

            _mainForm.DeleteButton.Click += Delete;
            _mainForm.InsertButton.Click += Insert;
            //--------------------------------------
            _mainForm.CleanupButton.Click += Cleanup;
            //--------------------------------------
            _mainForm.MoveButton.Click += Move;

            _mainForm.Combo.SelectedIndexChanged += SetTableName;
            _mainForm.Combo.SelectedIndexChanged += Read;

            _mainForm.FreeButton.Click += ShowStudentsWithoutRoom;
            _mainForm.Grid.RowHeaderMouseDoubleClick += Update;
            //---------------------------------------
            _mainForm.FindButton.Click += FindHandler;

            foreach (Form form in modalForms)
            {
                if (form is StudentForm)
                {
                    _studentForm = (StudentForm)form;
                }
                else if (form is RoomForm)
                {
                    _roomForm = (RoomForm)form;
                }
                else if (form is StudentRoomForm)
                {
                    _studentRoomForm = (StudentRoomForm)form;
                }
            }
        }

        // метод очистки комнаты по заданному id
        // вызываем процедуру из базы данных
        #region CleanupRoom
        private void Cleanup(object sender, EventArgs e)
        {
            string query = $"call cleanup_room({_mainForm.NumClean});";
            using (var context = new MyDbContext())
            {
                var result = context.Database.ExecuteSqlCommand(query);
            }
            Read(this, new EventArgs());
        }
        #endregion

        // метод перемещения студента из комнаты в другую
        // вызываем процедуру перемещения из базы данных, передавая в нее значения, выбранные в графическом интерфейсе
        #region MoveStudent
        private void Move(object sender, EventArgs e)
        {
            var studentId = _mainForm.Students.SelectedItem;
            string query = $"call move_student({studentId},{_mainForm.NumMove});";
            using (var context = new MyDbContext())
            {
                try
                {
                    var result = context.Database.ExecuteSqlCommand(query);
                    context.SaveChanges();
                }
                catch (Npgsql.PostgresException ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            Read(this, new EventArgs());
        }
        #endregion

        // свойство для получения выбранной строки в таблице
        private object TableRow { get; set; }

        // метод установки выбранной таблицы в поле (необходимо для выполнения управления с таблицами)
        private void SetTableName(object sender, EventArgs e)
        {
            _currentTableName = _mainForm.Combo.Text;
        }

        // метод заполнения выпадающего списка, заполняем его id студентов
        // можно было и полными именами, но в таком случае при полном соответствии
        // ФИО двух студентов будет не понятно кто есть кто, поэтому было приняторешение заполнять id
        #region FillComboBoxes
        private void FillStudentIdMainCombo()
        {
            _mainForm.Students.Items.Clear();
            using (var context = new MyDbContext())
            {
                foreach (var item in context.Students.ToList())
                {
                    _mainForm.Students.Items.Add(item.id);
                }
                _mainForm.Students.SelectedIndex = 0;
            }
        }

        private void FillCombos(MyDbContext context)
        {
            BindingList<KeyValuePair<int, string>> students =
                new BindingList<KeyValuePair<int, string>>();

            foreach (var i in context.Students.ToList())
            {
                students.Add(new KeyValuePair<int, string>
                    (i.id, $"{i.surname} {i.name} {i.middlename}"));
            }
            _studentRoomForm.Students.ValueMember = "Key";
            _studentRoomForm.Students.DisplayMember = "Value";
            _studentRoomForm.Students.DataSource = students;

            BindingList<KeyValuePair<int, int>> rooms =
                 new BindingList<KeyValuePair<int, int>>();
            foreach (var i in context.Rooms.ToList())
            {
                rooms.Add(new KeyValuePair<int, int>
                    (i.id, i.numberofroom));
            }
            _studentRoomForm.Rooms.ValueMember = "Key";
            _studentRoomForm.Rooms.DisplayMember = "Value";
            _studentRoomForm.Rooms.DataSource = rooms;
        }
        #endregion

        // вызов метода отображения студентов не привязанных к комнатам
        // вызываем процедуру из бд
        #region StudentWithoutRoom
        private List<Model.student> GetStudentWithoutRoom()
        {
            List<Model.student> result;
            string query = $"select * from show_students_without_room;";
            using (var context = new MyDbContext())
            {
                result = context
                    .Database
                    .SqlQuery<Model.student>(query).ToList();
            }
            return result;
        }

        private void ShowStudentsWithoutRoom(object sender, EventArgs e)
        {
            _mainForm.Tables.SelectedIndex = -1;
            _mainForm.Grid.DataSource = GetStudentWithoutRoom();
        }
        #endregion

        // Метод поиска по заданному параметру, вызываем процедуры из базы данных
        // которые привязаны к выбранной радио кнопке
        #region FindByParams
        private void FindHandler(object sender, EventArgs e)
        {
            _mainForm.Tables.SelectedIndex = -1;
            string query = null;

            if (_mainForm.CurrentCheckBox == "rbFindByBirthDay")
            {
                query = $"select * from find_by_birthday('{_mainForm.GetDTSearch}');";
            }
            else if (_mainForm.CurrentCheckBox == "rbFindBySurname")
            {
                query = $"select * from find_by_surname('{_mainForm.GetTextSearch}');";
            }
            else if (_mainForm.CurrentCheckBox == "rbFindByRoom")
            {
                query = $"select * from find_by_room('{_mainForm.GetNumSearch}');";
            }
            else if (_mainForm.CurrentCheckBox == "rbFindByCourse")
            {
                query = $"select * from find_by_course('{_mainForm.GetNumSearch}');";
            }
            else if (_mainForm.CurrentCheckBox == "rbFindByGroup")
            {
                query = $"select * from find_by_group('{_mainForm.GetTextSearch}');";
            }
            try
            {
                using (var context = new MyDbContext())
                {
                    var result = context
                         .Database
                         .SqlQuery<Model.MyFindResultView>(query).ToList();
                    _mainForm.Grid.DataSource = result;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check selected data.",
                                "Some Issue!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        // Метод для создания backup БД, выполняем shell команду с помощью класса Process
        // аналог консольной команды для дампа.
        // все значения забираем из строки подключения и разбираем ее на нужные параметры
        #region BackupData
        private void Backup(object sender, EventArgs e)
        {
            const string connName = "StudentResidenceEntities";
            var connItems = System.Configuration
                .ConfigurationManager
                .ConnectionStrings[connName].ConnectionString.Split(';');
            string host = connItems[2].Split('=').Last();
            string dbName = connItems[3].Split('=').Last();
            string userName = connItems[4].Split('=').Last();
            string password = connItems[5].Split('=').Last()
                .TrimEnd(new char[] { '\\','"' });

            _mainForm.BackupDialog.Filter = "Pdf files (All files (*.*)|*.*";
            if (_mainForm.BackupDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var dumpFileName = _mainForm.BackupDialog.FileName;
            string shellCmd = $"pg_dump --dbname=postgresql://" +
                $"{userName}:{password}" +
                $"@{host}:5432" +
                $"/{dbName} > {dumpFileName}";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            //process.StartInfo.Arguments = shellCmd;
            process.Start();
            process.StandardInput.WriteLine(shellCmd);
            process.StandardInput.Flush();
            process.StandardInput.Close();

            process.WaitForExit();

            if (process.ExitCode == 0)
            {
                MessageBox.Show($"Backup успешно записан в {dumpFileName}!");
            }
        }
        #endregion
    }
}
