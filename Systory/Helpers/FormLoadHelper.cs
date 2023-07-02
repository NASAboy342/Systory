using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systory.Managers
{
    public class FormLoadHelper
    {
        public void LoadSubformInPanel(Panel panel,Form form)
        {
            var formToLoad = form;
            formToLoad.TopLevel = false;
            panel.Controls.Add(formToLoad);
            formToLoad.Show();
            formToLoad.BringToFront();
        }
        public void LoadSubformInForm(Form perentForm, Form loadForm)
        {
            var formToLoad = loadForm;
            formToLoad.TopLevel = false;
            perentForm.Controls.Add(formToLoad);
            formToLoad.Show();
            formToLoad.BringToFront();
        }
    }
}
