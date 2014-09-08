using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GalaSoft.MvvmLight;

namespace NayamodeApp.Model
{
    public class AttendeeRootobject
    {
        public ObservableCollection<AttendeeModel> Data { get; set; }
    }

    public class AttendeeModel : INotifyPropertyChanged
    {
        
        public string _Id;
        public string _Name;
        public string _First;
        public string _Last;
        public string _Company;
        public bool _IsMicrosoft;
        public bool _IsCEO;
        public string _Title;
        public string _Biography;
        public string _Type;
        public string _Photo;
        public ObservableCollection<string> _SessionIds;
        public bool _IsSpeaker;

        public string Id { get { return _Id; } set { _Id = value; OnPropertyChanged(); } }
        public string Name { get { return _Name; } set { _Name = value; OnPropertyChanged(); } }
        public string First { get { return _First; } set { _First = value; OnPropertyChanged(); } }
        public string Last { get { return _Last; } set { _Last = value; OnPropertyChanged(); } }
        public string Company { get { return _Company; } set { _Company = value; OnPropertyChanged(); } }
        public bool IsMicrosoft { get { return _IsMicrosoft; } set { _IsMicrosoft = value; OnPropertyChanged(); } }
        public bool IsCEO { get { return _IsCEO; } set { _IsCEO = value; OnPropertyChanged(); } }
        public string Title { get { return _Title; } set { _Title = value; OnPropertyChanged(); } }
        public string Biography { get { return _Biography; } set { _Id = value; OnPropertyChanged(); } }
        public string Type { get { return _Type; } set { _Type = value; OnPropertyChanged(); } }
        public string Photo { get { return _Photo; } set { _Photo = value; OnPropertyChanged(); } }
        public ObservableCollection<String> SessionIds { get { return _SessionIds; } set { _SessionIds = value; OnPropertyChanged(); } }
        public bool IsSpeaker { get { return _IsSpeaker; } set { _IsSpeaker = value; OnPropertyChanged(); } }


        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
