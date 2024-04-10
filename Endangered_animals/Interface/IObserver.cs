using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals.Interface
{
    public interface IObserver
    {
        void OnDataChanged(object sender, EventArgs e);
    }
}
