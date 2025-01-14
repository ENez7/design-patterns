﻿using SimpleDecorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecorator.Decorators
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {
        }
        
        public override string Operation()
        {
            return $"ConcreteDecoratorB({ base.Operation() })";
        }
    }
}
