using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    public struct Marks
    {
        public int mark;
        public Subject subject;
        public Marks(int mark, Subject subject)
        {
            this.mark = mark;
            this.subject = subject;
        }
    }
}
