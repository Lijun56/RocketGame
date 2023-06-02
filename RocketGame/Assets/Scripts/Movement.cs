using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float MainThrust = 1000f;
    [SerializeField] float RotateThrust =  3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotate();
    }
    void ProcessThrust(){

        if(Input.GetKey(KeyCode.Space)){
            rb.AddRelativeForce(Vector3.up * MainThrust * Time.deltaTime );
        }
        

    }
    void ProcessRotate(){
        if(Input.GetKey(KeyCode.A)){
            ApplyRotation(RotateThrust);
        }
        
        else if(Input.GetKey(KeyCode.D)){
            ApplyRotation(-RotateThrust);

        }
    }
    private void ApplyRotation(float RotateThrust){
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * RotateThrust * Time.deltaTime);
        rb.freezeRotation = false; //freeze the rotation when apply rotation because we want keep the direction correct
        //unfreeze rotation because we want the physics be correct( like be hit by the obsticals that can change the rotation of the object) 

    }
    
}
