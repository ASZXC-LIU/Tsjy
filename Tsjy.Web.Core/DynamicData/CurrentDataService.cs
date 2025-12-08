using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootstrapBlazor.Components;

namespace Tsjy.Web.Core.DynamicData
{
    public class CurrentDataService
    {
        public SelectedItem CurrentDepartment { get; set; }

        public SelectedItem CurrentMajor { get; set; }

        public SelectedItem CurrentCourse { get; set; }
    }
}
