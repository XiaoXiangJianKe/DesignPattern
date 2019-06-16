﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 抽象主题
    /// </summary>
    abstract class Subject
    {
        public abstract void Attach(Observer observer);
        public abstract void Detach(Observer observer);
        public abstract void Notify();
    }
}
