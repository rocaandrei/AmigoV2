﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoV2
{
    public interface ISchedule
    {
        object ShuffleEngineers();
        void AddWorkdays();
        void AddShifts();
        void ShowSchedule();
    }
}
