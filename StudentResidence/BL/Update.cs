using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentResidence.BL
{
    partial class MainController
    {
        // модификация данных, работает также как и добавление
        // только применяется другая операция для контекста
        // вместо добавление, просто сохраняем измененный контекст, который получен из контролов
        #region UpdateModal
        private void UpdateModal(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                if (_currentTableName == "Студенты")
                {
                    var entry = context.Students
                        .Where(it => it.id == ((Model.student)TableRow).id)
                        .FirstOrDefault();
                    entry.surname = _studentForm.StudentSurname;
                    entry.name = _studentForm.StudentName;
                    entry.middlename = _studentForm.StudentMiddleName;
                    entry.phonenumber = _studentForm.PhoneNumber;
                    entry.birthday = _studentForm.StudentBirthDay;
                    entry.studentgroup = _studentForm.StudentGroup;
                    entry.course = _studentForm.StudentCourse;
                    entry.birthday = _studentForm.StudentBirthDay;
                    _studentForm.Close();
                }
                else if (_currentTableName == "Комнаты")
                {

                    var entry = context.Rooms
                        .Where(it => it.id == ((Model.room)TableRow).id)
                        .FirstOrDefault();
                    entry.seatscount = _roomForm.SeatsNum;
                    entry.numberofroom = _roomForm.NumberNum;
                    _roomForm.Close();
                }
                else if (_currentTableName == "Комнаты-Студенты")
                {
                    var entry = context.StudentsRooms
                        .Where(it => it.id == ((Model.studentsroom)TableRow).id)
                        .FirstOrDefault();
                    dynamic student = _studentRoomForm.Students.SelectedItem;
                    entry.student_id = student.id;
                    _studentRoomForm.Close();
                }
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // После обновления данных, обновляем таблицу.
            Read(this, new EventArgs());
        }
        #endregion


        // используем приведение типов, когда извлекаем данные из строки таблицы
        // необходимо, чтобы заполнить текущими значениями элементы модального окна
        // т.к выполняется операция модификации.
        // также не забываем отписываться от события, чтобы не возникли события при вызове метода добавления
        #region Update
        private void Update(object sender, EventArgs e)
        {
            TableRow = _mainForm.Grid.SelectedRows[0].DataBoundItem;
            if (_currentTableName == "Студенты")
            {
                _studentForm.StudentSurname = ((Model.student)TableRow).surname;
                _studentForm.StudentName = ((Model.student)TableRow).name;
                _studentForm.StudentMiddleName = ((Model.student)TableRow).middlename;
                _studentForm.PhoneNumber = ((Model.student)TableRow).phonenumber;
                _studentForm.StudentBirthDay = ((Model.student)TableRow).birthday;
                _studentForm.StudentGroup = ((Model.student)TableRow).studentgroup;
                _studentForm.StudentCourse = ((Model.student)TableRow).course;
                _studentForm.ApplyButton.Click += UpdateModal;
                _studentForm.ShowDialog();
                _studentForm.ApplyButton.Click -= UpdateModal;
            }
            else if (_currentTableName == "Комнаты")
            {
                _roomForm.NumberNum = ((Model.room)TableRow).numberofroom;
                _roomForm.SeatsNum = ((Model.room)TableRow).seatscount;
                _roomForm.ApplyButton.Click += UpdateModal;
                _roomForm.ShowDialog();
                _roomForm.ApplyButton.Click -= UpdateModal;
            }
            // Метод read лучше оставить в обработчике модального окна
            // чтобы не обновлять грид, если данные не модифицировались.
        }
        #endregion
    }
}
