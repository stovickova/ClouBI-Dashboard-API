﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public interface IEntity<TKey>
    {
        TKey Id { get; }
    }
}
