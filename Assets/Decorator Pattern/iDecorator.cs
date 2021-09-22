using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public interface iDecorator : ICloneable
    {
        void Initialize(iDecoratorData decoratorData);
        void Execute(iDecoratorData decoratorData);
        void Remove(iDecoratorData decoratorData);
    }
}

