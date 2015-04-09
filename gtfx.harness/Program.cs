using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx.harness
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game.Instance.Start("New Game", MainMenuState.State);
        }
    }
    public class MainMenuState
        : IState
    {
        public static MainMenuState State = new MainMenuState();
        public void Enter(IStateMachine sm, UpdateEventArgs u)
        {
            
        }

        public void Update(IStateMachine sm, UpdateEventArgs u)
        {
            
        }

        public void Exit(IStateMachine sm, UpdateEventArgs u)
        {
            
        }
    }

}
