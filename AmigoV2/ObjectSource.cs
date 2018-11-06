using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmigoV2.enums;

namespace AmigoV2
{
    public class ObjectSource : ISource, ISchedule
    {
        private List<Engineer> _engineers = new List<Engineer>() { };
        Random randomNo = new Random();
        public ObjectSource()
        {
            _engineers.Add(new Engineer(1, "Andrei", "Junior Dev", "male"));
            _engineers.Add(new Engineer(2, "Ionut", "Senior Dev CSharp", "male"));
            _engineers.Add(new Engineer(3, "Cosmin", "Senior Dev Java", "male"));
            _engineers.Add(new Engineer(4, "Gica", "Junior Dev JAVA", "male"));
            _engineers.Add(new Engineer(5, "Atos", "Senior Dev PHP", "male"));
            _engineers.Add(new Engineer(6, "Gelu", "Senior Dev C++", "male"));
            _engineers.Add(new Engineer(7, "Costi", "Junior Dev Php", "male"));
            _engineers.Add(new Engineer(8, "Alina", "Junior Dev C++", "female"));
            _engineers.Add(new Engineer(9, "Tache", "Junior Dev CSharp", "male"));
            _engineers.Add(new Engineer(10, "Ianche", "Senior Dev JavaScript", "male"));
            _engineers.Add(new Engineer(11, "Kadar", "Senior Dev CSharp", "male"));
            _engineers.Add(new Engineer(12, "Olga", "Senior Dev Payton", "male"));
        }
        public object GetEngineers()
        {
            //return _engineers.Select(o => new
            //{ Column1 = o.EngineerID, Column2 = o.EngineerName, Column3 = o.EngineerRole, Column4 = o.Gender }).ToList();
            return _engineers.ToList();
        }
        public void DeleteEngineer(BindingSource bidingSource, int engineerID)
        {
            var querry = from eng in _engineers
                         where eng.EngineerID == engineerID
                         select eng;
            var engineer = querry.Single();
            _engineers.Remove(engineer);
            bidingSource.Remove(engineer);
        }
        public void AddEngineer(BindingSource bidingSource, Engineer engineer)
        {
            int nextId = int.MinValue;
            foreach (var eng in _engineers)
            {
                if (nextId <= eng.EngineerID)
                {
                    nextId = eng.EngineerID + 1;
                }
            }
            engineer.EngineerID = nextId;
            _engineers.Add(engineer);
            bidingSource.Add(engineer);

        }
        public void Save()//not aplicable
        {
            MessageBox.Show("Nu este cazul de Save() pentru ObjectSource pentru ca el ia obiectul venit din compilare", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Update(BindingSource bidingSource, Engineer updatedEngineer)
        {
            foreach (var eng in _engineers)
            {
                if (eng.EngineerID == updatedEngineer.EngineerID)
                {
                    eng.EngineerName = updatedEngineer.EngineerName;
                    eng.EngineerRole = updatedEngineer.EngineerRole;
                    eng.Gender = updatedEngineer.Gender;
                }
            }
        }

        public object ShuffleEngineers()
        {
            List<Engineer> shuffledEngineers = new List<Engineer>();
            shuffledEngineers = _engineers;

            int n = shuffledEngineers.Count;
            for (int i = 0; i < n; i++)
            {
                int random = i + randomNo.Next(n - i);
                var temp = shuffledEngineers[random];
                shuffledEngineers[random] = shuffledEngineers[i];
                shuffledEngineers[i] = temp;
            }
            return shuffledEngineers.ToList(); ;
        }

        public object AddShifts()
        {
            var engineersWithShifts = ShuffleEngineers() as List<Engineer>;

            for (int i = 0; i < engineersWithShifts.Count; i++)
            {
                if (i % 2 != 0)
                {
                    engineersWithShifts[i].Shift = Shift.FirstShift;
                }
                else
                {
                    engineersWithShifts[i].Shift = Shift.SecondShift;
                }
            }
            return engineersWithShifts.ToList();
        }

        public object AddWorkdays()
        {
            var engineersWithWorkdays = AddShifts() as List<Engineer>;

            for (int i = 0; i < engineersWithWorkdays.Count; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    switch (j)
                    {
                        case 1:
                            engineersWithWorkdays[0].Workday = Workdays.Luni;
                            engineersWithWorkdays[1].Workday = Workdays.Luni;
                            break;
                        case 2:
                            engineersWithWorkdays[2].Workday = Workdays.Marti;
                            engineersWithWorkdays[3].Workday = Workdays.Marti;
                            break;
                        case 3:
                            engineersWithWorkdays[4].Workday = Workdays.Miercuri;
                            engineersWithWorkdays[5].Workday = Workdays.Miercuri;
                            break;
                        case 4:
                            engineersWithWorkdays[6].Workday = Workdays.Joi;
                            engineersWithWorkdays[7].Workday = Workdays.Joi;
                            break;
                        case 5:
                            engineersWithWorkdays[8].Workday = Workdays.Vineri;
                            engineersWithWorkdays[9].Workday = Workdays.Vineri;
                            break;
                        default:
                            break;
                    }
                }
            }
            return engineersWithWorkdays.ToList();
        }

        public object ShowSchedule()
        {
            var calendarOneWeek = AddWorkdays() as List<Engineer>;

            return calendarOneWeek.ToList();
        }
    }
}
