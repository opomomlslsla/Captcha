using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Captcha.Domain.ValueObjects;

namespace Captcha.Domain.Entities
{
    public class MousePositionData : BaseEntity
    {
        public PositionsData PositionsData { get; set; }
    }
}
