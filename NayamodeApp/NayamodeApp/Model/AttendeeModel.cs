using System;
using System.Collections.Generic;

namespace NayamodeApp.Model
{
    public class AttendeeRootobject
    {
        public List<AttendeeModel> Data { get; set; }
    }

    public class AttendeeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Company { get; set; }
        public bool IsMicrosoft { get; set; }
        public bool IsCEO { get; set; }
        public string Title { get; set; }
        public string Biography { get; set; }
        public string Type { get; set; }
        public string Photo { get; set; }
        public List<String> SessionIds { get; set; }
        public bool IsSpeaker { get; set; }
    }

}
