using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace StudentResidence.Views
{
    public partial class MainForm : Form
    {
        // поле для хранения имя текущей радио кнопки
        private string rbName;
        public MainForm()
        {
            InitializeComponent();
            grid.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCells;
            // подписываем события переключения радио кнопок
            rbFindByBirthDay.CheckedChanged += RadioButtonChecked;
            rbFindByCourse.CheckedChanged += RadioButtonChecked;
            rbFindByGroup.CheckedChanged += RadioButtonChecked;
            rbFindByRoom.CheckedChanged += RadioButtonChecked;
            rbFindBySurname.CheckedChanged += RadioButtonChecked;

            grid.BorderStyle = BorderStyle.None;
        }
        
        // свойства для доступа контроллера к представлению.

        public Button Manage => btnManage;

        public SaveFileDialog BackupDialog => saveBackupDialog;

        public Button Backup => btnBackup;

        public ComboBox Tables => cbTables;

        public Button MoveButton => btnMove;

        public ComboBox Students => cbStudents;

        public int NumMove => (int)numMove.Value;

        //---------------------------------------

        public Button CleanupButton => btnCleanup;

        public int NumClean => (int)numCleanup.Value;

        public DataGridView Grid => grid;

       // public DataGridView InfoGrid => infoGrid;

        public ComboBox Combo => cbTables;

        public Button DeleteButton => btnDelete;

        public Button InsertButton => btnInsert;

        public Button FreeButton => btnShowFree;

        // -----------------------------------------

        public Button FindButton => btnFind;

        public string GetTextSearch => tbSearch.Text;

        public int GetNumSearch => (int)numSearch.Value;

        public string GetDTSearch =>
            $"{dtpBirth.Value.Month}-" +
            $"{dtpBirth.Value.Day}-" +
            $"{dtpBirth.Value.Year}";

        public string CurrentCheckBox => rbName;

        // метод для переключения радио кнопок
        private void RadioButtonChecked(object sender, EventArgs e)
        {
            rbName = groupSearch.Controls
                .OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
            if (rbName == "rbFindByBirthDay")
            {
                tbSearch.Visible = false;
                numSearch.Visible = false;
                dtpBirth.Visible = true;
            }
            else if (rbName == "rbFindBySurname" ||
                     rbName == "rbFindByGroup")
            {
                tbSearch.Visible = true;
                numSearch.Visible = false;
                dtpBirth.Visible = false;
            }
            else
            {
                tbSearch.Visible = false;
                numSearch.Visible = true;
                dtpBirth.Visible = false;
            }
        }

        // обработчик события закрытия формы
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        // обработчик события нажатия на кнопку управления для отображения/сокрытия элементов
        private void btnManage_Click(object sender, EventArgs e)
        {
            groupManage.Visible = true;
            groupSearch.Visible = false;
        }

        // обработчик события нажатия на кнопку поиска для отображения/сокрытия элементов
        private void btnSearch_Click(object sender, EventArgs e)
        {
            groupManage.Visible = false;
            groupSearch.Visible = true;
        }
    }
}
