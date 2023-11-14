using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;
    public float horizontalInput;
    public float forwardInput;
    // Update is called once per frame
    void Update()
    {
        // get verticlal
        forwardInput = Input.GetAxis("Vertical");
        //get horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        //move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //left and right
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput * Time.deltaTime);
    }
}
