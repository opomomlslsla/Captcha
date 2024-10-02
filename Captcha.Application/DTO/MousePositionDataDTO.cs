using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha.Application.DTO
{
    public class MousePositionDataDTO
    {
        public Guid Id { get; set; }
        public int[] X { get; set; }
        public int[] Y { get; set; }
        public DateTime T { get; set; }
    }
}
