using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Devolucion
    {
        partial void Prestamista_Compute(ref string result)
        {
            // Establece el resultado en el valor del campo deseado
            result = this.Application.User.Name;
        }

        partial void Monto_Compute(ref decimal result)
        {
            // Establece el resultado en el valor del campo deseado
            // TODO: Establecer cómo se realizará el tipo de cobro.
            result = 0;
        }

        partial void HoraDevolucion_Compute(ref DateTime result)
        {
            // Establece el resultado en el valor del campo deseado
            result = DateTime.Now;

        }
    }
}
