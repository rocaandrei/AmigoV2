using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoV2
{
    class ObjectSource : ISource, ISchedule
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
            return _engineers;
        }
        public void DeleteEngineer(BindingSource bidingSource, int engineerID)
        {
            var querry = from eng in _engineers
                         where eng.EngineerID == engineerID
                         select eng;
            var engineer = querry.Single();
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
            return shuffledEngineers;
        }

        public void AddWorkdays()
        {
            throw new NotImplementedException();
        }

        public void AddShifts()
        {
            throw new NotImplementedException();
        }

        public void ShowSchedule()
        {
            throw new NotImplementedException();
        }
    }
}
