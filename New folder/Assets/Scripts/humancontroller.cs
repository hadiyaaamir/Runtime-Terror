using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humancontroller : MonoBehaviour
{

    private Transform _player;
    private Animator _animator;
    public int speed=8;
    public int distance=25;

    public AudioSource bitingAudio;
    public AudioSource screamingAudio;

    void Start()
    {
        _player=GameObject.Find("Player").transform;
        _animator = GetComponent<Animator>();
        

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
        bitingAudio.Play();
        screamingAudio.Play();
      _animator.SetTrigger("Standing React Death Backward");
       Destroy(this.gameObject);
      
      if(Sliderr.slidervalue <20) {
        Sliderr.slidervalue+=2;
      }
   }
}
