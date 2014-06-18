using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.observer_Pattern
{
    public class ColorSubject : ISubject
    {
        private Color  _Color = ColorSubject.blue;

        private Color Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
                Notify();
            }
        }

        #region ISubject Members
        private HashSet<IObserver> _observers = new HashSet<IObserver>();

        public void Register(IObserver  observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            _observers.Remove(observer);
        } 

        public void Notify()
        {
            _observers.ToList().ForEach( o  =>o.ColorChanged(Color));
        }

        #endregion
    }
}
