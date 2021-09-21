using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainCanvas : MonoBehaviour
{
    public GameObject mainCanvas;
    // Start is called before the first frame update
    void Start()
    {
         mainCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    public void StartGame()
    {
  
     mainCanvas.SetActive(false);
     Time.timeScale = 1;   
    }
}
