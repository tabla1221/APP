using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class ffestFlyoutMenuItem
    {
        public ffestFlyoutMenuItem()
        {
            TargetType = typeof(ffestFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}