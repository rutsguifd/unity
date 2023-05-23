using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
  
    public LayerMask canBeClicked;
    private NavMeshAgent myAgent;
    // [SerializeField] private float _playerspeed = 30f;
    void Start() {
        myAgent = GetComponent<NavMeshAgent>();
       

    }
    void Update( ){
        if(Input.GetMouseButton(0)){
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(myRay, out hitInfo,100, canBeClicked )){
                myAgent.SetDestination(hitInfo.point);
            }
        }


    }
    
   
}
