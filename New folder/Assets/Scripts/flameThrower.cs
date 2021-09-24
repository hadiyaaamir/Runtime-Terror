using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flameThrower : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource zombieGasp;
    public AudioSource death;
    public GameObject gameOver;

   
   void OnTriggerEnter(){
       zombieGasp.Play();
       Sliderr.slidervalue-=2;

       if(Sliderr.slidervalue == 0) {
           gameOver.SetActive(true);
           death.Play();
        }
   }
}
