﻿using Atma.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atma.Entity
{
    public interface IEntityManager : IEnumerable<int>
    {
        event OnEntity onEntityChange;
        event OnEntity onEntityAdd;
        event OnEntity onEntityRemove;

        int create();
        //IEntityRef create(params IComponent[] components);
        //IEntityRef create(string prefab);
        //int get(int id);
        bool exists(int id);
        void destroy(int e);
        int count { get; }
    }
}
