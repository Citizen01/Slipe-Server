﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SlipeServer.Server.Elements
{
    public enum WeaponTargetType
    {
        Vector,
        Entity,
        Fixed
    }

    public enum WeaponState
    {
        Ready,
        Firing,
        Reloading,
        OutOfAmmo,
        MeleeMadeContact
    }
}
