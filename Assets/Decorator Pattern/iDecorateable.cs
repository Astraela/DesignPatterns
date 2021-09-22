using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public interface iDecorateable
    {
        Decorator decorator { get; set; }
    }
}

