using Endangered_animals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals.Utility
{
    public abstract class ControlUIFactory
    {
        public abstract IControlUI CreateControlUI(object data);
        public abstract IControlUI CreateNewControl();
        public abstract void EditControlUI(IControlUI controlUI, object data);
        public abstract void DeleteControlUI(IControlUI controlUI);
    }
}
    