﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace OneWayService
{
    public class Reply : IReply
    {
        public void FastReply()
        {
            Thread.Sleep(5000);
        }

        public void SlowReply()
        {
            Thread.Sleep(5000);
        }
    }
}
