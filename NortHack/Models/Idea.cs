using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NortHack.Models
{
    public class Idea
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Profile> Profiles { get; set; }

    }
}