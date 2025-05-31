using Endangered_animals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endangered_animals.Utility
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyAll(object sender, EventArgs e)
        {
            foreach(var observer in observers)
            {
                observer.OnDataChanged(sender, e);
            }
            ShowNotification("Baza de date a fost actualizata!");
        }
        protected void ShowNotification(string message)
        {
            MessageBox.Show(message, "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
