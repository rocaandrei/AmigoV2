﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoV2
{
    public class Engineer
    {
        public int EngineerID { get; set; }
        public string EngineerName { get; set; }
        public string EngineerRole { get; set; }
        public string Gender { get; set; }
     

        public Engineer(int id, string name, string role, string gender)
        {
            EngineerID = id;
            EngineerName = name;
            EngineerRole = role;
            Gender = gender;
        }
        public Engineer()
        {
        }
    }
}
