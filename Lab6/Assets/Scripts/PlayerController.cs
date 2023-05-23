using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
      [SerializeField] Transform playerCamera = null;
      [SerializeField] float mouseSens = 3.5f;
    float cameraPitch = 0.0f;
    CharacterController contr = null;
   

    void Start()
    {
        contr = GetComponent<CharacterController>();
    }

    void Update()
    {
        UpdateMouseLook();
        UpdateMove();
    }
     void UpdateMouseLook(){

        Vector2 mouse = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));  
        transform.Rotate(Vector3.up*mouse.x);
        cameraPitch-=mouse.y;
        cameraPitch =Mathf.Clamp(cameraPitch, -90.0f, 90.0f);
        playerCamera.localEulerAngles = Vector3.right*cameraPitch;
        transform.Rotate(Vector3.up*mouse.x);

    }
     void UpdateMove(){
        Vector2 inp = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        inp.Normalize();
        Vector3 velocity = (transform.forward*inp.y+transform.right*inp.x)*mouseSens;
        contr.Move(velocity*Time.deltaTime);
    }
}
