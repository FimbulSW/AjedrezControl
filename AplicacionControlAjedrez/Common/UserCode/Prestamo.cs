using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Prestamo
    {
        public static readonly int HoraMaxima = 18;
        public static readonly int TiempoPrestamo = 2;

        partial void Prestamista_Compute(ref string result)
        {
            // Establece el resultado en el valor del campo deseado
            result = this.Application.User.Name;

        }

        partial void LimiteDevolucion_Compute(ref DateTime result)
        {
            // Establece el resultado en el valor del campo deseado
            //Se
            result = this.HoraPrestamo.AddHours(TiempoPrestamo);
            if(result.Hour >= HoraMaxima)
            {
                var now = DateTime.Now;
                result = new DateTime(now.Year, now.Month, now.Day, HoraMaxima, 0, 0);
            }
        }

        partial void HoraPrestamo_Compute(ref DateTime result)
        {
            // Establece el resultado en el valor del campo deseado
            result = DateTime.Now;
        }
    }
}
