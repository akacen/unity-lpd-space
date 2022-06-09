using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingControls : MonoBehaviour
{
    public float torque = 1000f;
    public float thrust = 1000f;
    private float glide;
    private Rigidbody rb;

    void Start()
    {
        glide = 0f;
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        float roll = Input.GetAxis("Horizontal");
        float pitch = Input.GetAxis("Vertical");
        bool throttle = Input.GetKey("space");

        rb.AddRelativeTorque(Vector3.forward * torque*10 * roll * Time.deltaTime); //for turning left and right
        rb.AddRelativeTorque(Vector3.left * torque * pitch * Time.deltaTime); // for turning up and down

        if(throttle){
            rb.AddRelativeForce(Vector3.down * thrust * Time.deltaTime); //lidot uz priekšu
            glide = thrust;
        } else {
            rb.AddRelativeForce(Vector3.down * glide * Time.deltaTime);
            glide *= 0.999f; //palēnina spaceship, bet labāk būtu ar grafiku
        }
    }
}
