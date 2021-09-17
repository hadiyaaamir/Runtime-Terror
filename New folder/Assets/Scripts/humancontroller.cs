using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humancontroller : MonoBehaviour
{

    private Transform _player;
    public int speed=3;
    public int distance=10;
    void Start()
    {
        _player=GameObject.Find("Player").transform;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!GameObject.Find("Player").GetComponent<playercontroller> ().isDead){
            if(Vector3.Distance(transform.position,_player.position)<= distance){
                transform.position= new Vector3 (transform.position.x,transform.position.y,transform.position.z - speed*Time.deltaTime);
            }
        }
    }

    void OnTriggerEnter(){
      // macheteAudio.Play();
       Destroy(this.gameObject);

       Sliderr.slidervalue++;
   }
}
