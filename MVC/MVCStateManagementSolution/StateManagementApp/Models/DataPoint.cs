﻿using System.Runtime.Serialization;

namespace StateManagementApp.Models
{
    [DataContract]
    public class DataPoint
    {
        [DataMember(Name = "label")]
        public string Label = "";

        [DataMember(Name = "y")]
        public Nullable<double> Y = null;

        public DataPoint(string label,double y)
        {
            this.Label = label;
            this.Y = y;
        }

    }
}
