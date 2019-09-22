using System;

namespace flwup.ApplicationCore.Model
{
    public class Step
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public int Type { get; set; }
        public int State { get; set; }
    }
}