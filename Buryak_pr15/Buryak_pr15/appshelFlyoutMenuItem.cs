﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buryak_pr15
{
    public class appshelFlyoutMenuItem
    {
        public appshelFlyoutMenuItem()
        {
            TargetType = typeof(appshelFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}