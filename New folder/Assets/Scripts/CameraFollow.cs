using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 _target = Vector3.zero;
    public playercontroller playerr;    


    

    // Update is called once per frame
    void Update()
    {
        if(playerr.isDead) {
            _target = new Vector3 (player.position.x, player.position.y + 3, player.position.z - 6);
        }
        else {
            _target = new Vector3 (player.position.x, player.position.y + 3, player.position.z - 4);
        }
        transform.position = Vector3.Lerp(transform.position, _target, 1f);
    }
}
