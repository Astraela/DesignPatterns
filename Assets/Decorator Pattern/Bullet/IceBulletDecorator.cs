using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class IceBulletDecorator : BaseDecorator
    {
        private GameObject iceParticles;
        public override void Initialize(iDecoratorData decoratorData)
        {
            BulletDecoratorData bulletDecoratorData = (BulletDecoratorData)decoratorData;
            iceParticles = GameObject.Instantiate(ServiceDesk.instance.iceParticles);
            iceParticles.transform.position = bulletDecoratorData.bullet.position;
            iceParticles.transform.parent = bulletDecoratorData.bullet;
        }

        public override void Execute(iDecoratorData decoratorData)
        {
            Debug.Log("ICE EFFECT");
        }

        public override void Remove(iDecoratorData decoratorData){
            GameObject.Destroy(iceParticles);
        }
    }
}

