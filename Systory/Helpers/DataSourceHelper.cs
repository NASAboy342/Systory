using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systory.Controller;

namespace Systory.Helpers
{
    public class DataSourceHelper
    {
        public void SetDataSocurceToDataGrid<T>(DataGridView dataGridView, List<T> listOfObject)
        {
            BindingSource _bindingSource = new BindingSource();
            _bindingSource.DataSource = listOfObject;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = _bindingSource;
        }
    }
}
