using Microsoft.Maui.Handlers;

namespace MauiApp1.Platforms.Windows
{
    public class NativeControlHandler : ViewHandler<INativeControl, NativeUserControl>
    {
        public static IPropertyMapper<INativeControl, NativeControlHandler> Mapper = new PropertyMapper<INativeControl, NativeControlHandler>(ViewHandler.ViewMapper)
        {
        };

        public NativeControlHandler() : base(Mapper)
        {
        }

        protected override NativeUserControl CreatePlatformView()
        {
            return new NativeUserControl();
        }
    }
}