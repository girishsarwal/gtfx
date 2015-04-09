using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class StateManager
    {
        public static void ChangeState(IStateMachine sm, IState newState){
            if (newState == null)
                return;
            if (newState == sm.CurrentState)
                return;
            if (sm.CurrentState != null)
                sm.CurrentState.Exit(sm, null);
            sm.PreviousState = sm.CurrentState;
            sm.CurrentState = newState;
            sm.CurrentState.Enter(sm, null);
        }
    }
}
