﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public interface ICallerStepEditing
    {        
        event Action StepEditing_required;
    }
}
