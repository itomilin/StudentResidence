using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentResidence.BL
{
    partial class MainController
    {
        // Метод удаления
        // вызывается по событию клика на кнопку удалить
        // запись пренадлежащая к выбранной таблице при этом удаляется.
        // некоторые записи удалить нельзя т.к каскадное удаление не включено
        // в таком случае просим использовать кнопку очистить комнату
        #region Delete
        private void Delete(object sender, EventArgs e)
        {
            if (_mainForm.Grid.SelectedRows.Count == 0)
            {
                return;
            }
            int id = int.Parse(_mainForm.Grid.SelectedRows[0].Cells[0].Value.ToString());
            using (var context = new MyDbContext())
            {
                try
                {
                    if (_currentTableName == "Студенты")
                    {
                        context.Students.Remove(context
                            .Students.Where(it => it.id == id).FirstOrDefault());
                    }
                    else if (_currentTableName == "Комнаты")
                    {
                        context.Rooms.Remove(context
                            .Rooms.Where(it => it.id == id).FirstOrDefault());
                    }
                    else if (_currentTableName == "Комнаты-Студенты")
                    {
                        context.StudentsRooms.Remove(context
                            .StudentsRooms.Where(it => it.id == id).FirstOrDefault());
                    }

                    context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Try \"Cleanup\" button.",
                        "Some Issue!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Read(this, new EventArgs());
        }
        #endregion
    }
}
