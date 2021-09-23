using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maincan : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject playerCanvas;
    public GameObject gameOver;
    public GameObject youWin;

    public playercontroller player;



    //private Scene scene;

    // Start is called before the first frame update
    
    void Start(){
        playerCanvas.SetActive(false);
        gameOver.SetActive(false);
        youWin.SetActive(false);
        mainCanvas.SetActive(true);
        Time.timeScale = 0;

        //scene = ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        mainCanvas.SetActive(false);
        playerCanvas.SetActive(true);
        Time.timeScale = 1;   
    }

    public void Restart() {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // player.starttt();
         gameOver.SetActive(false);
        //player.changeAnimation();
    }

    
}
