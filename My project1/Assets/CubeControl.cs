using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       // private float walkingSpeed = 0.2f;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))   
            transform.position += transform.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.E))
            transform.position +=transform.right * Time.deltaTime;
        if (Input.GetKey(KeyCode.Q))
            transform.position -= transform.right * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.Rotate (Vector3.up, 40 * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -40 * Time.deltaTime);

    }
}
