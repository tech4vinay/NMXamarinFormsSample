using NayamodeApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NayamodeApp.ViewModel
{
    public class SessionViewModel
    {

        public List<SessionModel> SessionList { get; set; }
        public ObservableCollection<SessionModel> SessionList { get; set; }

        

    }
}
