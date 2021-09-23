using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderr : MonoBehaviour
{

    public static int slidervalue = 10;
    public Slider slider;
    public GameObject youWin;

    //public AudioSource macarena;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = slidervalue;
        if (playercontroller.hasWon) {
            youWin.SetActive(true);
            //macarena.Play();
        }
    }
}
