using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CsLab01
{
    class AgeModel
    {
        public static string WestHoro(DateTime? bDate)
        {
            switch (bDate.Value.Month)
            {
                case 1:
                    return bDate.Value.Day < 20 ? "Capricon" : "Aquarius";
                    
                case 2:
                    return bDate.Value.Day < 19 ? "Aquarius" : "pisces";
                    
                case 3:
                    return bDate.Value.Day < 21 ? "pisces" : "aries";
                    
                case 4:
                    return bDate.Value.Day < 20 ? "aries" : "taurus";
                    
                case 5:
                    return bDate.Value.Day < 21 ? "taurus" : "gemini";
                    
                case 6:
                    return bDate.Value.Day < 21 ? "gemini" : "cancer";
                    
                case 7:
                    return bDate.Value.Day < 23 ? "cancer" : "leo";
                    
                case 8:
                    return bDate.Value.Day < 23 ? "leo" : "virgo";
                    
                case 9:
                    return bDate.Value.Day < 23 ? "virgo" : "libra";
                   
                case 10:
                    return bDate.Value.Day < 23 ? "libra" : "scorpio";
                    
                case 11:
                    return bDate.Value.Day < 22 ? "scorpio" : "sagittarius";
                    
                case 12:
                    return bDate.Value.Day < 22 ? "sagittarius" : "capricon";
                default:
                    return "";
            }
        }

        public static string ChineseZodiak(DateTime? bDate)
        {
            switch (bDate.Value.Year % 12)
            {
                case 0: return "monkey";
                case 1: return "rooster";
                case 2: return "dog";
                case 3: return "pig";
                case 4: return "rat";
                case 5: return "ox";
                case 6: return "tiger";
                case 7: return "rabbit";
                case 8: return "dragon";
                case 9: return "snake";
                case 10: return "horse";
                case 11: return "sheep";
                default: return "";
            }
        }

        public static bool IsBirthDay(DateTime? bDate, DateTime curDate)
        {
            return bDate == curDate;     
        }

        public static  bool IsValidAge(DateTime? bDate, DateTime curDate)
        {
            return (bDate <= curDate && curDate.Year - bDate.Value.Year <= 135);

        }
    }
}
