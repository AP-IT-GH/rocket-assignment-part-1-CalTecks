using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float verticalspeed = 500.0f;
    [SerializeField] private float horizontalspeed = 45.0f;
    [SerializeField] private float gravityMod = 0.3f;
    private float horizontalInput;
    private float verticalInput;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetKey(KeyCode.Space) ? 1.0f : 0.0f;
        Debug.Log(horizontalInput);
        Debug.Log(verticalInput);
        rb.AddRelativeForce(Vector3.up * Time.deltaTime * verticalspeed * verticalInput);
        rb.AddRelativeTorque(Vector3.right * Time.deltaTime * horizontalspeed * horizontalInput);
    }
}
