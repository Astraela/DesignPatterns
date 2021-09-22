using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class Shooter : MonoBehaviour
    {
        public GameObject bullet;
        
        public List<iDecorator> lmbDecorators = new List<iDecorator>(){new FireBulletDecorator()};
        public List<iDecorator> rmbDecorators = new List<iDecorator>(){new IceBulletDecorator()};
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Mouse0)){
                var newBullet = Instantiate(bullet,transform.position - new Vector3(0,2,0),Quaternion.identity);
                lmbDecorators.ForEach(x => newBullet.GetComponent<Bullet>().AddDecorator(x.Clone() as iDecorator));
            }
            else if(Input.GetKeyDown(KeyCode.Mouse1)){
                var newBullet = Instantiate(bullet,transform.position - new Vector3(0,2,0),Quaternion.identity);
                rmbDecorators.ForEach(x => newBullet.GetComponent<Bullet>().AddDecorator(x.Clone() as iDecorator));
            }
        }
    }
}
