using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResidence.BL
{
    partial class MainController
    {

        #region InsertModal
        private void InsertModal(object sender, EventArgs e)
        {
            // извлекаем данные из полей ввода и обновляем модель
            using (var context = new MyDbContext())
            {
                if (_currentTableName == "Студенты")
                {
                    Model.student entry = new Model.student()
                    {
                        name = _studentForm.StudentName,
                        surname = _studentForm.StudentSurname,
                        middlename = _studentForm.StudentMiddleName,
                        birthday = _studentForm.StudentBirthDay,
                        phonenumber = _studentForm.PhoneNumber,
                        course = _studentForm.StudentCourse,
                        studentgroup = _studentForm.StudentGroup
                    };
                    context.Students.Add(entry);
                    FillStudentIdMainCombo();
                    _studentForm.Close();
                }
                else if (_currentTableName == "Комнаты")
                {
                    Model.room entry = new Model.room()
                    {
                        numberofroom = _roomForm.NumberNum,
                        seatscount = _roomForm.SeatsNum
                    };

                    context.Rooms.Add(entry);
                    _roomForm.Close();
                }
                else if (_currentTableName == "Комнаты-Студенты")
                {
                    dynamic room = _studentRoomForm.Rooms.SelectedItem;
                    dynamic student = _studentRoomForm.Students.SelectedItem;
                    Model.studentsroom entry = new Model.studentsroom()
                    {
                        room_id = room.Key,
                        student_id = student.Key
                    };
                    _studentRoomForm.Close();
                    context.StudentsRooms.Add(entry);
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
            Read(this, new EventArgs());
        }
        #endregion

        // обработчик события вствки данных в таблицу
        // в зависимости от выбранной таблице вызываем модальное окно
        // для изменения и добавления используется одно и тоже модальное окно
        // поэтому не забываем отписываться от события, когда закрываем диалоговое окно
        #region Insert
        private void Insert(object sender, EventArgs e)
        {
            if (_currentTableName == "Студенты")
            {
                _studentForm.ApplyButton.Click += InsertModal;
                _studentForm.ShowDialog();
                _studentForm.ApplyButton.Click -= InsertModal;
            }
            else if (_currentTableName == "Комнаты")
            {
                _roomForm.ApplyButton.Click += InsertModal;
                _roomForm.ShowDialog();
                _roomForm.ApplyButton.Click -= InsertModal;
            }
            else if (_currentTableName == "Комнаты-Студенты")
            {
                using (var context = new MyDbContext())
                {
                    FillCombos(context);
                }
                _studentRoomForm.ApplyButton.Click += InsertModal;
                _studentRoomForm.ShowDialog();
                _studentRoomForm.ApplyButton.Click -= InsertModal;
            }
        }
        #endregion
    }
}
