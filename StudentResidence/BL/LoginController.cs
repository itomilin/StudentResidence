using System.Linq;
using StudentResidence.Views;

namespace StudentResidence.BL
{
    class LoginController
    {
        // поля хранящие ссылки на представления
        private readonly LoginForm _loginForm;
        private readonly MainForm _mainForm;

        // конструктор, получаем ссылки на представленя
        public LoginController(LoginForm loginForm,
            MainForm mainForm)
        {
            _loginForm = loginForm;
            _mainForm = mainForm;
            _loginForm.GetButton.Click += new System.EventHandler(Validation);
        }

        // валидация существующих данных в таблице users
        // если пароль или логин не совпадает, указываем это
        // также смотрим роль, если роль user, то программно скрываем элементы управления
        private void Validation(object sender, System.EventArgs e)
        {
            // if user exist in table, then show the new form
            using (var context = new BL.MyDbContext())
            {
                var userLogin = context
                    .Users
                    .FirstOrDefault(x => x.user_name == _loginForm.GetLogin.Text);
                if (userLogin is null)
                {
                    _loginForm.MyLabel.Visible = true;
                    _loginForm.MyLabel.Text = "Неправильный логин.";
                    return;
                }
                if (!SecurePasswordHasher.Verify(_loginForm.GetPassword.Text, userLogin.password))
                {
                    _loginForm.MyLabel.Visible = true;
                    _loginForm.MyLabel.Text = "Неправильный пароль.";
                    return;
                }
                _loginForm.MyLabel.Visible = false;
                if (userLogin.role == "user")
                {
                    _mainForm.Backup.Visible = false;
                    _mainForm.Manage.Visible = false;
                }
                _loginForm.Hide();
                _mainForm.Show();
            }
        }
    }
}
