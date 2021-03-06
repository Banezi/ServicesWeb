﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public abstract class EntityObject
    {
        public int ID { get; set; }
        static private int NextID = 0;

        public EntityObject()
        {
            ID = NextID;
            NextID++;
        }
    }
}
