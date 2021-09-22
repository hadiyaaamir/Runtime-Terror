using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincan : MonoBehaviour
{
    public GameObject mainCanvas;
    // Start is called before the first frame update
    public void StartGame()
    {
     Application.LoadLevel(Application.loadedLevel);
     mainCanvas.SetActive(false);
     Time.timeScale = 1;   
    }
    void Start(){
        mainCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    public void Restart()
    {
        
    }
}
