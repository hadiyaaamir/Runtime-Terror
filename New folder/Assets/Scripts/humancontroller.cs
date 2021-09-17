using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humancontroller : MonoBehaviour
{

    private Transform _player;
    public int speed=10;
    public int distance=100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!GameObject.find("Player").GetComponent<PlayerController> ().isDead){
            if(Vector3.Distance(transform.position,_player.position)<= distance){
                transform.position= new Vector3 (transform.positon.x,transform.positon.y,transform.positon.z - speed*Time.deltaTime);
            }
        }
    }
}
