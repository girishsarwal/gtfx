using SlimDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtfx
{
    public class ShaderManager
        : LookupManager<string, ShaderProgram>
    {
        public static string ShaderRoot =  Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "shaders");

        private static ShaderManager _instance;
        public static ShaderManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShaderManager();
                return _instance;
            }
        }
        private ShaderManager()
        {
            
        }

        public override void Initialize()
        {
            try
            {
                foreach (string file in Directory.GetFiles(ShaderRoot, "*.?s", SearchOption.AllDirectories))
                {
                    ShaderBytecode bc = ShaderBytecode.CompileFromFile(file, "main", "", ShaderFlags.None);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            base.Initialize();
        }
        
    }
}
