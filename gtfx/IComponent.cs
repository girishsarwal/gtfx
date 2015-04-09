using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public interface IComponent
    {
        String Name { get; set; }
        bool Enabled { get; set; }
        bool Initialized { get; set; }
        void Initialize();
        void Update (UpdateEventArgs e);
    }
}
