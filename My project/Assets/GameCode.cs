using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCode : MonoBehaviour
{
    public float forceMagnitude = 10f; // The force to apply to the object
    private Rigidbody rb; // The object's Rigidbody component
    private Camera cam; // The main camera in the scene
    private Vector3 forceDirection;

    public GameObject myball;

    private void Start()
    {
        rb = myball.GetComponent<Rigidbody>(); // Get the Rigidbody component when the script starts
        cam = Camera.main; // Get the main camera in the scene
        forceDirection = Vector3.right;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Check if the spacebar is currently pressed
        {
             rb.AddForce(forceDirection * forceMagnitude, ForceMode.Force);
            // Apply the force to the object's Rigidbody
        }
    }
}
