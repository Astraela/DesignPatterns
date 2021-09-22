using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class Decorator{
        private List<iDecorator> decorators = new List<iDecorator>();

        public void AddDecorator(iDecorator decorator, iDecoratorData decoratorData){
            decorators.Add(decorator);
            decorator.Initialize(decoratorData);
        }

        public void RemoveDecorator(iDecorator decorator, iDecoratorData decoratorData){
            var toDelete = decorators.Find(x => x.GetType().IsAssignableFrom(decorator.GetType()));
            toDelete?.Remove(decoratorData);
            decorators.Remove(toDelete);
        }

        public void Execute(iDecoratorData decoratorData){
            decorators.ForEach(x => x.Execute(decoratorData));
        }
    }
}