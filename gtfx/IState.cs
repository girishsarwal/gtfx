using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public interface IState
    {
        void Enter(IStateMachine sm, UpdateEventArgs u);
        void Update(IStateMachine sm, UpdateEventArgs u);
        void Exit(IStateMachine sm, UpdateEventArgs u);
    }
}
