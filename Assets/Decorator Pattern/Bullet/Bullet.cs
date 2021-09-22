using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class Bullet : MonoBehaviour, iDecorateable
    {
        private Decorator _decorator = new Decorator();
        public Decorator decorator { get => _decorator; set {_decorator = value;} }
        public BulletDecoratorData decoratorData = new BulletDecoratorData();
        public float damage = 10;

        private Rigidbody rigidb;
        
        private void Awake(){
            decoratorData.damage = damage;
            decoratorData.bullet = transform;
            rigidb = GetComponent<Rigidbody>();
            transform.LookAt(GameObject.FindObjectOfType<Enemy>().transform,Vector3.down);
        }

        private void Update()
        {
            transform.Translate(Vector3.forward * 20 * Time.deltaTime);
        }

        public void AddDecorator(iDecorator _decorator){
            this._decorator.AddDecorator(_decorator,decoratorData);
        }
    }
}
