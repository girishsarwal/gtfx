using SlimDX.Direct3D11;
using SlimDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class ShaderProgram
    {
        private SlimDX.Direct3D11.VertexShader vs;
        private SlimDX.Direct3D11.PixelShader ps;

        public ShaderProgram(string vertexShader, string pixelShader)
        {
            ShaderBytecode byc =  ShaderBytecode.CompileFromFile(vertexShader, "main", "vs_3_0", ShaderFlags.None);
        }
    }
}
