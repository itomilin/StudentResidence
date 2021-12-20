using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResidence.BL
{
    partial class MainController
    {
        // метод для чтения таблицы в datagridview
        // в зависимости от выбранной таблицы берем entity контекст и заполняем datasource таблицы
        #region Read
        private void Read(object sender, EventArgs e)
        {
            FillStudentIdMainCombo(); // Обновляем содержимое фио студентов.
            using (var context = new MyDbContext())
            {
                if (_currentTableName == "Студенты")
                {
                    _mainForm.Grid.DataSource = context.Students.ToList();
                }
                else if (_currentTableName == "Комнаты")
                {
                    _mainForm.Grid.DataSource = context.Rooms.ToList();
                }
                else if (_currentTableName == "Комнаты-Студенты")
                {
                    _mainForm.Grid.DataSource = context.StudentsRooms
                        .ToList().Select(i => new Model.MyStudentRoom
                        {
                            StudentId = i.student_id,
                            RoomId = i.room_id,
                            RoomNumber = i.room.numberofroom,
                            StudentFullName = $"{i.student.surname} {i.student.name} {i.student.middlename}"
                        }).ToList();
                    //_mainForm.Grid.DataSource = context.StudentsRooms.ToList();
                }
            }
        }
        #endregion
    }
}
