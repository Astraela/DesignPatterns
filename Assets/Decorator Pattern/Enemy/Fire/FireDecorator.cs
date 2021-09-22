using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class FireDecorator : BaseDecorator
    {
        private GameObject fireParticles;
        public override void Initialize(iDecoratorData decoratorData)
        {
            EnemyDecoratorData enemyDecoratorData = (EnemyDecoratorData)decoratorData;
            enemyDecoratorData.health += 5;
            fireParticles = GameObject.Instantiate(ServiceDesk.instance.fireParticles);
            fireParticles.transform.position = enemyDecoratorData.enemy.transform.position + ServiceDesk.instance.fireParticles.transform.position;
            fireParticles.transform.parent = enemyDecoratorData.enemy.transform;
        }

        public override void Execute(iDecoratorData decoratorData)
        {
            Debug.Log("FIRE EFFECT");
        }

        public override void Remove(iDecoratorData decoratorData)
        {
            ((EnemyDecoratorData)decoratorData).health -= 5;
            GameObject.Destroy(fireParticles);
        }
    }
}

