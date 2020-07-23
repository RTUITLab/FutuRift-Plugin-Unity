﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Plugins.UnityChairPlugin.ChairControl.ChairWork.Options
{
    [Serializable]
    public class UdpOptions
    {
        public string ip = "127.0.0.1";
        public int port = 6065;
    }
}
