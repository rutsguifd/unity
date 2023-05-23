using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoScript : MonoBehaviour
{
    public float force = 169f;
    void Start() {}
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
        GetComponent<Rigidbody>().AddForce(new Vector3(0f,0f,1f*force),ForceMode.Impulse);
        }
        
    }
}
