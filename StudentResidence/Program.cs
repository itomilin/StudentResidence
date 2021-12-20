using System;
using System.Windows.Forms;
using StudentResidence.Views;

namespace StudentResidence
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Тестовое подключение к бд, чтобы проверить правильность строки подключения
            // и существования бд
            using (var context = new BL.MyDbContext())
            {
                try
                {
                    context.Database.Connection.Open();
                    context.Configuration.LazyLoadingEnabled = false;
                }
                catch (Npgsql.PostgresException ex)
                {
                    MessageBox.Show($"{ex.MessageText}\n" +
                        $" check the connection string!",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Invalid ConnectionString name.",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }

            // создание объектов представления и контроллеров
            LoginForm loginForm = new LoginForm();
            MainForm mainForm = new MainForm();
            BL.MainController mainController = new BL.MainController(mainForm,
                new Form[] { new RoomForm(), new StudentForm(), new StudentRoomForm() });

            new BL.LoginController(loginForm, mainForm);

            Application.Run(loginForm);
        }
    }
}
