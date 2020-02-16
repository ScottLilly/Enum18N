using System;
using System.Windows.Forms;

namespace EnumI18N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProjectStatus.DataSource = LocalizedEnums.ProjectStates.ToList();
            cboProjectStatus.DisplayMember = LocalizedEnums.DISPLAY_MEMBER;
            cboProjectStatus.ValueMember = LocalizedEnums.VALUE_MEMBER;
        }
    }
}
