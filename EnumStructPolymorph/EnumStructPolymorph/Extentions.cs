using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStructPolymorph
{
    static public class Extentions
    {
        public static bool CompareString(this string firstStr, string secondStr, Cases cases)
        {
            switch (cases)
            {
                case Cases.CaseSensative:
                    if (firstStr == secondStr)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case Cases.CaseInSensative:
                    if (firstStr.Equals(secondStr, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case Cases.UpperCase:
                    if (firstStr == secondStr.ToUpper())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case Cases.LowerCase:
                    if (firstStr == secondStr.ToLower())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }
    }
}
