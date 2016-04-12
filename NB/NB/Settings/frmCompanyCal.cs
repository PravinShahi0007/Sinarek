using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NB
{
    public partial class frmCompanyCal : Telerik.WinControls.UI.RadForm
    {
        public frmCompanyCal()
        {
            InitializeComponent();
        }

        private void frmCompanyCal_Load(object sender, EventArgs e)
        {
            
            radCalendar1.SelectedDate = DateTime.Now;

        }

        private void radCalendar1_ElementRender(object sender, RenderElementEventArgs e)
        {
            //if (e.Day.Date == DateTime.Now.Date)
            //{
            
            ////}
            if (e.Day.TemplateItem == null)
            {
                RadTextBox txt = new RadTextBox();
                txt.Text = "<html>"
                               + "test" + "<br /><p>Aha</p>" +
                               "</html>";
                RadHostItem hostItem = new RadHostItem(txt);
                //e.Day.TemplateItem.cl
                //e.Day.TemplateItem = hostItem;
                //e.Element.Text = "<html>"
                //               + e.Day.Date.Day.ToString() + "<br /><p>Aha</p>" +
                //               "</html>";
            }

        }

        private void radCalendar1_ControlAdded(object sender, ControlEventArgs e)
        {
            //e.Control
        }

        private void radCalendar1_RootElement_ChildrenChanged(object sender, ChildrenChangedEventArgs e)
        {
            if (e.ChangeOperation == ItemsChangeOperation.Inserted)
            {

            }
        }

        private void btnSetYear_Click(object sender, EventArgs e)
        {

        }
    }
}
