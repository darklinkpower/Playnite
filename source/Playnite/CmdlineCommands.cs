﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playnite
{
    public enum CmdlineCommand : int
    {
        Start = 0,
        Focus = 1,
        UriRequest = 2,
        ExtensionInstall = 3,
        SwitchMode = 4,
        Shutdown = 5
    }
}
