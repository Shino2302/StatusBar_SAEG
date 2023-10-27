using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Input;
using Xamarin.Forms;

namespace StatusBar_SAEG.ViewModel
{
    public class VMMainPage
    {
        public VMMainPage()
        {
            
        }
        public void Ocultar()
        {
            DependencyService.Get<VMStatusBar>().OcultarStatusBar();
        }
        public void Mostrar()
        {
            DependencyService.Get<VMStatusBar>().MostrarStatusBar();
        }
        public void Traslicido()
        {
            DependencyService.Get<VMStatusBar>().Traslucido();
        }
        public void Transparente()
        {
            DependencyService.Get<VMStatusBar>().Transparente();
        }
        public void CambiarColor()
        {
            DependencyService.Get<VMStatusBar>().CambiarColor();
        }

        public ICommand OcuultarCommand => new Command(Ocultar);
        public ICommand MostrarCommand => new Command(Mostrar);
        public ICommand TraslucidoCommand => new Command(Traslicido);
        public ICommand TransparenteCommand => new Command(Transparente);
        public ICommand CambiarColorCommand => new Command(CambiarColor);

    }
}
