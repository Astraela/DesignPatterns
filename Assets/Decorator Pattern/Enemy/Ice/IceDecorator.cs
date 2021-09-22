using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class IceDecorator : BaseDecorator
    {
        private GameObject iceParticles;
        public override void Initialize(iDecoratorData decoratorData)
        {
            EnemyDecoratorData enemyDecoratorData = (EnemyDecoratorData)decoratorData;
            enemyDecoratorData.health += 10;
            iceParticles = GameObject.Instantiate(ServiceDesk.instance.iceParticles);
            iceParticles.transform.position = enemyDecoratorData.enemy.transform.position + ServiceDesk.instance.iceParticles.transform.position;
            iceParticles.transform.parent = enemyDecoratorData.enemy.transform;
        }

        public override void Execute(iDecoratorData decoratorData)
        {
            Debug.Log("ICE EFFECT");
        }

        public override void Remove(iDecoratorData decoratorData){
            ((EnemyDecoratorData)decoratorData).health -= 10;
            GameObject.Destroy(iceParticles);
        }
    }
}

