using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Mark
    {
        public DateTime date{ get; set; }
        public string Estimation { get; set; }

        public static List<string> Estimations => new List<string>()
        {
            "1",
            "2",
            "3",
            "4",
            "5",
            "н",
            "нуп",
            "п",
            "б",
        };
    }
}