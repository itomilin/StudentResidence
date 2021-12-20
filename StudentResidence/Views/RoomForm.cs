using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResidence.Views
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        // свойства для получения элементов управления и данных, которые находятся в них
        public Button ApplyButton => btnApply;

        public int NumberNum
        {
            get
            {
                return (int)numNumberOfRoom.Value;
            }
            set
            {
                numNumberOfRoom.Value = value;
            }
        }

        public int SeatsNum
        {
            get
            {
                return (int)numSeatsCount.Value;
            }
            set
            {
                numSeatsCount.Value = value;
            }
        }

        // обнуление полей ввода при закрытии окна
        private void RoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            numNumberOfRoom.Value = 0;
            numSeatsCount.Value = 0;
        }
    }
}
