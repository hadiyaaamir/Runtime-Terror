using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flameThrower : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource zombieGasp;
   
   void OnTriggerEnter(){
       zombieGasp.Play();
       Sliderr.slidervalue-=2;
   }
}
