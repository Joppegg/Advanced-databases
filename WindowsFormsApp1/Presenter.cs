using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Uppgift2Wform
{
    class Presenter
    {
        private Form1 view_form;
        private ModelDal model = new ModelDal();

        public Presenter(Form1 form)
        {
            view_form = form;
        }
        public List<String> ColumnNames()
        {
            return model.ColumnNames();
        }
        public List<String> RowsNumber()
        {
            return model.RowsNumber();
        }
        public List<string> TableNames()
        {

            return model.TableNames();
        }
        public void PopulateTables()
        {
          
       
        }
    }
}
