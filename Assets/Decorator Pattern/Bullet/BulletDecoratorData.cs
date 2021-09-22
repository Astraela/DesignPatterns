using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class BulletDecoratorData : iDecoratorData{
        public Transform bullet;
        public float damage;
    }
}