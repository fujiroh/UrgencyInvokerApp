using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace UrgencyInvokeApplication
{
    public partial class ControlDockingForm : DockContent
    {
        public ControlDockingForm()
        {
            InitializeComponent();
        }

        public void SetControl(Control control)
        {
            this.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
    }
}
