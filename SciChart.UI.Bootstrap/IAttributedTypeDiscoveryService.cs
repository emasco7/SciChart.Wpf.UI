﻿using System;
using System.Collections.Generic;

namespace SciChart.UI.Bootstrap
{
    public interface IAttributedTypeDiscoveryService
    {
        IEnumerable<Type> DiscoverAttributedTypes<T>() where T : Attribute;
    }
}
