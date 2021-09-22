using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class EnemyDecoratorData : iDecoratorData{
        public Enemy enemy;
        public float health;
    }
}