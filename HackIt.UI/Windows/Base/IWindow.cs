﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackIt.UI.Windows.Base
{
    public abstract class IWindow
    {
        abstract public void ReDraw();

        public Window ParentWindow;
    }
}