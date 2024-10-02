using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha.Domain.Entities
{
    public class MousePositionData : BaseEntity
    {
        public int[] X { get; set; }
        public int[] Y { get; set; }    
        public DateTime T { get; set; }
    }
}
