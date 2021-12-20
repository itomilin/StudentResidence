using System.Windows.Forms;

namespace StudentResidence.Views
{
    public partial class StudentRoomForm : Form
    {
        public StudentRoomForm()
        {
            InitializeComponent();
        }

        // свойства для получения элементов управления.
        public Button ApplyButton => btnApply;

        public ComboBox Students => cbStudents;

        public ComboBox Rooms => cbRooms;
    }
}
