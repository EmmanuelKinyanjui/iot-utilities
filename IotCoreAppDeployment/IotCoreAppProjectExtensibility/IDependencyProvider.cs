﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotCoreAppProjectExtensibility
{
    public interface IDependencyProvider
    {
        Dictionary<String, IDependency> GetSupportedDependencies();
    }
}