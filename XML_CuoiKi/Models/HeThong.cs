﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_CuoiKi.Models
{
    class HeThong
    {
        connect connect = new connect();
        public void TaoXML()
        {
            connect.TaoXML("NguoiDung");
        }
    }
}