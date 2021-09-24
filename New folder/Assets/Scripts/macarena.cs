using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class macarena : MonoBehaviour
{

    public AudioSource macarenaAudio;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(playercontroller.hasWon) {
            macarenaAudio.Play();
        }
    }
}
