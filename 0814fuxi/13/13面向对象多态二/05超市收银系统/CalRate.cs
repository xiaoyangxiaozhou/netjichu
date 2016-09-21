﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05超市收银系统
{
    /// <summary>
    /// 按折扣率打折
    /// </summary>


    class CalRate:CalFather
    {
        public double Rate
        {
            get;
            set;
        }
        public CalRate(double rate)
        {
            this.Rate=rate;
        }
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney*this.Rate;
        }

    }
}
