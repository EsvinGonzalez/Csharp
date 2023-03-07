using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo__2
{
    class TiposDeDatos
    {
        public static void Main(string[] args)
        {
            sbyte byteConSigno = sbyte.MaxValue;
            byte byteSinSigno = byte.MaxValue;
            short shortConSigno = short.MaxValue;
            ushort ushortSinSigno = ushort.MaxValue;
            int intConSigno = int.MaxValue;
            uint uintSinSigno = uint.MaxValue;
            long longConSigno = long.MaxValue;
            ulong ulongSinSigno = ulong.MaxValue;
            float floatValor = float.MaxValue;
            double doubleValor = double.MaxValue;
            decimal decimalValor = decimal.MaxValue;



            Console.WriteLine("MAX[sbyte]: {0}", byteConSigno);
            Console.WriteLine("MAX[byte]: {0}", byteSinSigno);
            Console.WriteLine("MAX[short]: {0}", shortConSigno);
            Console.WriteLine("MAX[ushort]: {0}", ushortSinSigno);
            Console.WriteLine("MAX[int]: {0}", intConSigno);
            Console.WriteLine("MAX[uint]: {0}", uintSinSigno);
            Console.WriteLine("MAX[long]: {0}", longConSigno);
            Console.WriteLine("MAX[unlog]: {0}", ulongSinSigno);
            Console.WriteLine("MAX[float]: {0}", floatValor);
            Console.WriteLine("MAX[double]: {0}", doubleValor);
            Console.WriteLine("MAX[decimal]: {0}", decimalValor);
            
        }
    }
}
