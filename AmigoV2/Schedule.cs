using AmigoV2.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoV2
{
    public class Schedule
    {
        public Engineer Engineer { get; set; }
        public Shift Shift { get; set; }
        public Workdays Workday { get; set; }
        public Schedule(Engineer eng, Shift shift, Workdays workday)
        {
            Engineer = eng;
            Shift = shift;
            Workday = workday;
        }
    }
}
