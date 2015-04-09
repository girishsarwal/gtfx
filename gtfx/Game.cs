using SlimDX.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class Game
        : IStateMachine
    {
        
        public String Name { get; private set; }
        public IState InitialState { get; private set; }
        private static Game _instance = null;
        public static Game Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Game();
                return _instance;
            }
        }
        public void Initialize()
        {
            Renderer.Instance.Initialize(Name);     /** init render subsystem **/
            EntityManager.Instance.Initialize();    /** init entity management subsystem **/
            ShaderManager.Instance.Initialize();    /** init shader subsystem **/
        }

        public void Start(string title, IState initialState)
        {
            Name = title;
            Initialize();
            StateManager.ChangeState(this, initialState);
            MessagePump.Run(Renderer.Instance.Surface, Loop);
        }

        public static void Loop()
        {
            
        }


        public IState CurrentState
        {
            get;
            set;
        }

        public IState PreviousState
        {
            get;
            set;
        }
    }
}
