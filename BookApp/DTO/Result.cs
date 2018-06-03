using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DTO
{
    class Result
    {
        private int chapid;
        private int firstIndex;
        private int lastIndex;

        public Result() { }

        public Result(int chapid, int firstIndex, int lastIndex)
        {
            this.chapid = chapid;
            this.firstIndex = firstIndex;
            this.lastIndex = lastIndex;
        }
        public int getChapId()
        {
            return this.chapid;
        }

        public int getFirstIndex()
        {
            return this.firstIndex;
        }

        public int getLastIndex()
        {
            return this.lastIndex;
        }

    }
}
