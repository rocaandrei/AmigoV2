using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoV2
{
    public interface ISchedule
    {
        void ShuffleEngineers();
        void AddWeekdays();
        void AddShifts();
        void ShowSchedule();
    }
}
