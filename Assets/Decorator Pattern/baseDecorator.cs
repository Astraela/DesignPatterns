using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class BaseDecorator : iDecorator
    {
        public virtual void Initialize(iDecoratorData decoratorData)
        {
        }

        public virtual void Execute(iDecoratorData decoratorData)
        {
        }

        public virtual void Remove(iDecoratorData decoratorData)
        {
        }

        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
    
