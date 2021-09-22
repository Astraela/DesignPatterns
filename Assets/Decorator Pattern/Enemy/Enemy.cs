using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class Enemy : MonoBehaviour, iDecorateable
    {
        [SerializeField] private float health = 100;
        Decorator _decorator = new Decorator();
        EnemyDecoratorData decoratorData = new EnemyDecoratorData();

        public Decorator decorator { get => _decorator; set {_decorator = value;} }

        void Awake(){
            decoratorData.enemy = this;
            decoratorData.health = health;
        }

        // Start is called before the first frame update
        void Start()
        {
            _decorator.AddDecorator(new FireDecorator(),decoratorData);
            _decorator.AddDecorator(new IceDecorator(),decoratorData);
            _decorator.RemoveDecorator(new IceDecorator(), decoratorData);
            _decorator.Execute(decoratorData);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}

