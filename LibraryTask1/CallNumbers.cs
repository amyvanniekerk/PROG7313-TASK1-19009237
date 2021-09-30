using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask1
{
    class CallNumbers
    {
     // Generating getters and setters 
        public int nums { get; set; }
        public string chars { get; set; }

    // Generating the constructor 
        public CallNumbers(int nums, string chars)
        {
            this.nums = nums;
            this.chars = chars;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}",nums,chars);
        }
    }
}