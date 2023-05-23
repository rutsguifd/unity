using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinish : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            Debug.Log("FINISH!");
        }
    }
    void OnTriggerStay(Collider other) {
        if(other.tag == "Player"){
            Debug.Log("You've reached the finish!");
        }
    }
}

