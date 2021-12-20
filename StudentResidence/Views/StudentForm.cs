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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        // свойства для получения контролов и значений, которые находятся в них
        public Button ApplyButton => btnApply;

        public string StudentName
        {
            get
            {
                return tbName.Text;
            }
            set
            {
                tbName.Text = value;
            }
        }

        public string StudentSurname
        {
            get
            {
                return tbSurname.Text;
            }
            set
            {
                tbSurname.Text = value;
            }
        }

        public string StudentMiddleName
        {
            get
            {
                return tbMiddleName.Text;
            }
            set
            {
                tbMiddleName.Text = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return tbPhoneNumber.Text;
            }
            set
            {
                tbPhoneNumber.Text = value ;
            }
        }

        public int StudentCourse
        {
            get
            {
                return (int)numCourse.Value;
            }
            set
            {
                numCourse.Value = (int)value;
            }
        }

        public string StudentGroup
        {
            get
            {
                return tbGroup.Text;
            }
            set
            {
                tbGroup.Text = value;
            }
        }

        public DateTime StudentBirthDay
        {
            get
            {
                return dtpBirthDay.Value;
            }
            set
            {
                dtpBirthDay.Value = value;
            }
        }

        // обнуление форм ввода, при закрытии формы
        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            tbGroup.Text = null;
            tbMiddleName.Text = null;
            tbName.Text = null;
            tbPhoneNumber.Text = null;
            tbSurname.Text = null;
            dtpBirthDay.Value = DateTime.Now;
            numCourse.Value = 0;
        }
    }
}
