using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    void OnTriggerEnter(){
       playercontroller._velocity = Vector3.zero;
       }
}
