using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class macheteScript : MonoBehaviour
{
   public AudioSource macheteAudio;
   
   void OnTriggerEnter(){
       macheteAudio.Play();
       Destroy(this.gameObject);
       
       Sliderr.slidervalue = Sliderr.slidervalue-1;
   }
   
}
