using System;
using System.Collections.Generic;
using System.Text;

namespace StatusBar_SAEG.ViewModel
{
    public interface VMStatusBar
    {
        void OcultarStatusBar();
        void MostrarStatusBar();
        void Traslucido();
        void Transparente();
        void CambiarColor();
    }
}
