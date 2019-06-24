using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVCCoreAJAX.oUtil
{
    public class Utilidad
    {
        public string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch = Convert.ToChar("a");
            for (int i = 0; i < size; i++)
            {
                int mayusculas = Convert.ToInt32(Math.Floor(2 * random.NextDouble() + 1));
                int entero = Convert.ToInt32(Math.Floor(2 * random.NextDouble() + 1));
                switch (entero)
                {
                    case 1:
                        switch (mayusculas)
                        {
                            case 1:
                                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                                ch = Convert.ToChar(ch.ToString().ToUpper());
                                break;
                            case 2:
                                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                                ch = Convert.ToChar(ch.ToString().ToLower());
                                break;
                        }
                        break;
                    case 2:
                        string cadena = Convert.ToString(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                        ch = Convert.ToChar(cadena.Substring(0, 1));
                        break;
                }

                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
