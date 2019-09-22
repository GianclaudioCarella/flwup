using System;
using System.Collections.Generic;
using System.Text;

namespace flwup.ApplicationCore.Model
{
    public class Process
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public int Type { get; set; }
        public int SubType { get; set; }
        public List<Step> Steps { get; set; }
        public Owner Owner { get; set; }
        public List<Subscriptor> Subscriptors { get; set; }
    }
}
