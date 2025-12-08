using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootstrapBlazor.Components;
using static System.Net.Mime.MediaTypeNames;

namespace Tsjy.Web.Core.ConstData
{
    public static class ConstItems
    {

        public static List<SelectedItem> RoleItems = new List<SelectedItem>()
        {
        new SelectedItem() { Text = "选择用户角色",Value = "Anonymous"},
        new SelectedItem() { Text = "系统管理员",Value = "SystemAdmin"},
        new SelectedItem() { Text = "市县",Value = "County"},
        new SelectedItem() { Text = "学校",Value = "School"}

    };
    }
}
