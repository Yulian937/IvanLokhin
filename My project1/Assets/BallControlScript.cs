using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BallControlScript : MonoBehaviour
{
    Rigidbody rb;
    float kickStrenghts = 800;
    // Start is called before the first frame update
    void Awake()
    {
        
        rb= GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void Update()
    {   if (Input.GetMouseButton(0))
        {
            KickBall(transform);
        }

        

    }

    public void KickBall(Transform kicker)
    {
        rb.AddExplosionForce(kickStrenghts, kicker.position, 4);
      

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        { print("Boing!"); }

        else
        {
            zombieControlScript testIfZombie = collision.gameObject.GetComponent<zombieControlScript>();
            if (testIfZombie != null)
            {
                testIfZombie.dieNow();
            }
            print("Ouch!");

            KickBall(collision.transform);
        }
    }
}
