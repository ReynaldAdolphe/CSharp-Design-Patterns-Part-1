using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // Concrete Subject
    public class GClooney : ICelebrity
    {        
        private readonly List<IFan> _fans = new List<IFan>();   // Collection
        private string _tweet;                                  // Backing field        

        public GClooney(string tweet){                          // Constructor
            _tweet = tweet;
        }

        public string FullName => "George Clooney";
        public string Tweet
        {
            get{ return _tweet;}

            set
            {
                Notify(value);
            }
        }

        public void AddFollower(IFan fan) {
            _fans.Add(fan);
        }

        public void RemoveFollower(IFan fan) {
            _fans.Remove(fan);
        }

        public void Notify(string tweet)
        {
            _tweet = tweet;
            foreach (var fan in _fans)
            {
                fan.Update(this);
            }
        }
    }
}
