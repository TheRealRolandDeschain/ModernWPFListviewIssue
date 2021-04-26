using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWPFListviewIssue
{
    public class MyViewModel :ViewModelBase
    {
        public ObservableCollection<ControllableLedModel> ControllableLedList { get; set; }

        public MyViewModel()
        {
            ControllableLedList = new ObservableCollection<ControllableLedModel>();
            for (int i = 0; i < 50; i++)
            {
                ControllableLedList.Add(new ControllableLedModel(i * 1.5, i * 2.5, (uint)(i * 10)));
                ControllableLedList.Last().ID = (uint)i;
            }
        }
    }
}
