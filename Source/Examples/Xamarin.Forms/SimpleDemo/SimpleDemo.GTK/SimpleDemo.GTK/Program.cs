using OxyPlot.Xamarin.Forms.Platform.GTK;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace SimpleDemo.GTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            PlotViewRenderer.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.Show();
            Gtk.Application.Run();
        }
    }
}