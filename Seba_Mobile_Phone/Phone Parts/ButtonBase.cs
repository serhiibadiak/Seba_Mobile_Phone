﻿using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Phone.Interfaces;

namespace Seba_Mobile_Phone
{
    public abstract class ButtonBase
    {
        public abstract void Click(IButtonClick button);
    }
}
