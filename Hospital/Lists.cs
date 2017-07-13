using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    partial class Sobe
    {
        public List<string> shobeName = new List<string>() {
            "Pediatriya", "Stomatologiya", "Terapiya"
        };
        public List<string> pediatriyaDoctors = new List<string>()
        {
            "Fikret Hesenov", "Ruslan Bedelov", "Murad Tagiyev"
        };
        public List<string> stomatologiyaDoctors = new List<string>()
        {
            "Nusret Orucov", "Tamerlan Allahverdiyev", "Aleksey Kuznetsov"
        };
        public List<string> terapiyaDoctors = new List<string>()
        {
            "Michael Connor", "William Shapes", "Andrew Lincoln"
        };
    }
}
