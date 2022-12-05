using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLib
{
    public class FractionClass
    {
        public string FixWrongResult(string text)
        {
            string[] result = text.Split(new char[] { '/' });
            int indexSlash = text.IndexOf('/');


            if (text == "" || text == "/" || result.Length != 2 || !result[0].All(char.IsDigit) || !result[1].All(char.IsDigit) || indexSlash == -1)
            {
                throw new Exception("Exteption");
            }
            else
            {
                if (int.Parse(result[0]) < int.Parse(result[1]))
                {
                    return text;
                }
                else
                {
                    result[0] = result[1];

                    return string.Join("/", result);
                }
            }
        }
    }
}
