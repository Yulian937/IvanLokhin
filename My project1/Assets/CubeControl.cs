using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))   
            transform.position += transform.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += transform.backw * Time.deltaTime;
        if (Input.GetKey(KeyCode.E))
            transform.position += (new Vector3(5, 0, 0)) * Time.deltaTime;
        if (Input.GetKey(KeyCode.Q))
            transform.position += (new Vector3(-5, 0, 0)) * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.Rotate (Vector3.up, 20 * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, -20 * Time.deltaTime);

    }
}
