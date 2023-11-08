using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BallControlScript : MonoBehaviour
{
    Rigidbody rb;
    float kickStrenghts = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
        rb= GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void Update()
    {   if (Input.GetMouseButton(0))
        {
            KickBall();
        }

        

    }

    void KickBall()
    {
        rb.AddForce(kickStrenghts * Vector3.up, ForceMode.Impulse);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        { print("Boing!"); }

        else
            print("Ouch!");
        KickBall();
    }
}
