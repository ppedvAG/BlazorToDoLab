using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorToDoLab.Model
{
    public class ViewModel
    {
        public List<Aufgabe> Liste { get; set; }
        public event EventHandler PropertyChangedEvent;

        public  void PropertyChanged()
        {
            PropertyChangedEvent?.Invoke(this, EventArgs.Empty);
        }
        public void AddAufgabe(Aufgabe a)
        {
            Liste.Add(a);
            PropertyChanged();
        }
    }
}
