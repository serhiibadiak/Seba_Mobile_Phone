﻿using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib
{
    public abstract class ButtonBase
    {
        public abstract void Click(IButtonClick button);
    }
}
