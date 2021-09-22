using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern{
    public class ServiceDesk : MonoBehaviour{
        public GameObject iceParticles;
        public GameObject fireParticles;

        public static ServiceDesk instance;

        private void Start(){
            instance = this;
        }
    }
}