using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPENSOURCE
{
    public class CheckedListBoxItem
    {
        public string Name { get; set; }
        public bool IsChecked { get; set; }
        public CheckedListBoxItem(string name, bool isChecked)
        {
            Name = name;
            IsChecked = isChecked;
        }
    }
}
