﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MtaServer.Server.Elements.IdGeneration
{
    public class ElementIdsExhaustedException : Exception
    {
        public ElementIdsExhaustedException() : base("Element Ids exhausted")
        {
        }
    }
}
