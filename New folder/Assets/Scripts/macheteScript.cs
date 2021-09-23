using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class macheteScript : MonoBehaviour
{
   public AudioSource macheteAudio;
   public GameObject gameOver;
   
   void OnTriggerEnter(){
       macheteAudio.Play();
       Destroy(this.gameObject);

       Sliderr.slidervalue--;
       if(Sliderr.slidervalue == 0) {
           gameOver.SetActive(true);
        }
   }
   
}
