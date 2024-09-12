using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai
{
    static class StrignExtension
    {
        public static bool isValid(this string sor)
        {
            var stack = new Stack<string>();
            for (int i = 0; i < sor.Length; i++)
            {
                if (sor[i] == '(')
                {
                    stack.Push(sor[i].ToString());
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception)
                    {

                        return false;
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }

    }
}
