using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFileReader
{
    class Presenter
    {
        private Form1 view_form;

        private DAL model = new DAL();
        public Presenter(Form1 form)
        {
            view_form = form;
        }
        public void ShowText()
        {
            view_form.fileText = model.FetchText(view_form.fileTextName);

        }

    }
}
