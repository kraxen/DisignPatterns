﻿using System;

namespace BehaviorPatterns.Strategy
{
    public class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }
}
