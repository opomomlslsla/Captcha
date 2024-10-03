using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha.Domain.ValueObjects
{
    public class PositionsData
    {
        public int[] X { get; set; }
        public int[] Y { get; set; }
        public DateTime T { get; set; }
    }
}
