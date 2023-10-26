using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControlScript : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
        rb= GetComponent<Rigidbody>();
    }
    float kickStrenght = 0.2f;
    

    // Update is called once per frame
    void Update()
    {   if(Input.GetMouseButton(0))         
            rb.AddForce(kickStrenght * Vector3.up, ForceMode.Impulse);
        



    }
}
