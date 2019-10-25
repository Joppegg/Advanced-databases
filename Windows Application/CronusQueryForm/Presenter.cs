using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronusQueryForm
{
    class Presenter
    {
        private Form1 view;
        private Model model = new Model();
        public Presenter(Form1 m_view)
        {
            view = m_view;
        }

        public void PopulateTables(DataGridView keysTable, DataGridView indexTable, DataGridView constraintsTable, DataGridView tablesTable, DataGridView columnsTable, DataGridView employeesTables, DataGridView relativesTable, DataGridView absenceTable, DataGridView mostAbsentTable)
        {
            DataTable dtblKeys = model.GetKeys();
            keysTable.DataSource = dtblKeys;

            DataTable dtblIndexes = model.GetIndexes();
            indexTable.DataSource = dtblIndexes;

            DataTable dtblConstraints = model.GetConstraints();
            constraintsTable.DataSource = dtblConstraints;

            DataTable dtblColumns = model.GetColumns();
            columnsTable.DataSource = dtblColumns;
        
            DataTable dtblTables = model.GetTables();
            tablesTable.DataSource = dtblTables;

            DataTable dtblEmployees = model.GetEmployees();
            employeesTables.DataSource = dtblEmployees;

            DataTable dtblRelatives = model.GetRelatives();
            relativesTable.DataSource = dtblRelatives;

            DataTable dtblAbsence = model.GetAbsence();
            absenceTable.DataSource = dtblAbsence;

            DataTable dtblMostAbsent = model.GetMostAbsent();
            mostAbsentTable.DataSource = dtblMostAbsent;

        }


    }
}
