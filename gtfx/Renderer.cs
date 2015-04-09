using SlimDX;
using SlimDX.Direct3D11;
using SlimDX.DXGI;
using SlimDX.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class Renderer
    {
        private SlimDX.Direct3D11.Device device = null;
        public SlimDX.Direct3D11.Device Device
        {
            get
            {
                return device;
            }
        }
        private SwapChain swapChain = null;
        public SwapChain SwapChain
        {
            get
            {
                return swapChain;
            }
        }

        public RenderForm Surface
        {
            get;
            set;
        }

        private static Renderer _instance;
        public static Renderer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Renderer();
                return _instance;
            }
        }
        private Renderer()
        {

        }

        public void Initialize(String title)
        {
            Surface = new RenderForm(title);
            Initialize(title, Surface.Handle);
        }
        
        public void Initialize(String title, IntPtr handle)
        {
            SlimDX.Direct3D11.Device.CreateWithSwapChain(SlimDX.Direct3D11.DriverType.Hardware, DeviceCreationFlags.None, new SwapChainDescription()
            {
                BufferCount = 1,
                Usage = Usage.RenderTargetOutput,
                OutputHandle = handle,
                IsWindowed = true,
                ModeDescription = new ModeDescription(0, 0, new Rational(60, 1), Format.R8G8B8A8_UNorm),
                SampleDescription = new SampleDescription(1, 0),
                Flags = SwapChainFlags.AllowModeSwitch,
                SwapEffect = SwapEffect.Discard
            }, out device, out swapChain);
        }
    }
}
