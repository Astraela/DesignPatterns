using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class FireBulletDecorator : BaseDecorator
    {
        private GameObject fireParticles;
        public override void Initialize(iDecoratorData decoratorData)
        {
            BulletDecoratorData bulletDecoratorData = (BulletDecoratorData)decoratorData;
            fireParticles = GameObject.Instantiate(ServiceDesk.instance.fireParticles);
            fireParticles.transform.position = bulletDecoratorData.bullet.position;
            fireParticles.transform.parent = bulletDecoratorData.bullet;
        }

        public override void Execute(iDecoratorData decoratorData)
        {
            Debug.Log("FIRE EFFECT");
        }

        public override void Remove(iDecoratorData decoratorData)
        {
            GameObject.Destroy(fireParticles);
        }
    }
}

