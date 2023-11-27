using System;
using System.Windows.Forms;

namespace UrgencyInvokeApplication.CustomControls
{
    public partial class CustomPropertyPanel : UserControl
    {
        public CustomPropertyPanel()
        {
            InitializeComponent();
        }

        private void _closeButton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}