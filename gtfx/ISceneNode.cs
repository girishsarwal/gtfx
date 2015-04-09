using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public interface ISceneNode
    {
        Boolean CanBeNamed
        {
            get;
        }
        String Name 
        { 
            get; 
            set; 
        }
        GameObject GameObject
        {
            get;
            set;
        }
        void Update(UpdateEventArgs args);
    }
}
