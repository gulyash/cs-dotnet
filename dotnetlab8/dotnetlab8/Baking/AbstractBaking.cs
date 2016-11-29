﻿using System;
using dotnetlab8.Kitchen;

namespace dotnetlab8.Baking
{
    public abstract class AbstractBaking : ICloneable //поддержка интерфейса ICloneable
    {
        private Pastry _pastry;
        private Filling _filling;
        private int _weight;
        public Pastry pastry { get { return _pastry; } set { _pastry = value; } }
        public Filling filling { get { return _filling; } set { _filling = value; } }
        public int weight { get { return _weight; } set { _weight= value; } }

        public abstract object Clone();
    }
}