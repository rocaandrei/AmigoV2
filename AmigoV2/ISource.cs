﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoV2
{
    public interface ISource : ISchedule
    {
        object GetEngineers();
        void DeleteEngineer(BindingSource bidingSource, int engineerID);
        void AddEngineer(BindingSource bidingSource,Engineer engineer);
        void Save();
        void Update(BindingSource bidingSource, Engineer engineer);
    }
}
