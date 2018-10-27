using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoV2
{
    class ObjectSource : ISource
    {
        private List<Engineer> _engineers = new List<Engineer>() { };

        public ObjectSource()
        {
            _engineers.Add(new Engineer(1, "Andrei", "Junior Dev", "male", null));
            _engineers.Add(new Engineer(2, "Ionut", "Senior Dev", "male", null));
            _engineers.Add(new Engineer(3, "Cosmin", "Senior Dev", "male", null));
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
                if(nextId <= eng.EngineerID)
                {
                    nextId = eng.EngineerID + 1;
                }
            }
            engineer.EngineerID = nextId;
            bidingSource.Add(engineer);
           
        }
        public void Save()
        {
            MessageBox.Show("Nu este cazul de Save() pentru ObjectSource pentru ca el ia obiectul venit din compilare", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //nu este cazul de implementare pentru ca la complilare vom avea aceleasi obiecte definite intial 
        }
    }
}
