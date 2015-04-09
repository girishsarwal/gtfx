using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public interface IStateMachine
    {
        IState CurrentState { get; set; }
        IState PreviousState { get; set; }
    }
}
