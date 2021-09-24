using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishLine : MonoBehaviour
{
    public AudioSource macarenaAudio;
    public AudioSource baudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(){
        baudio.Stop();
        macarenaAudio.Play();
        Destroy(this.gameObject);
        
    }
}
