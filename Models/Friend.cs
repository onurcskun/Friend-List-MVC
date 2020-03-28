using System;
using System.Collections.Generic;

namespace MVC_PROJECT.Models {
    public partial class Friend {
        public int id { get; set; }
        public string fullName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string livesIn { get; set; }
    }
}