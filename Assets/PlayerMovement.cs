using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // reference to the rigidbody to access. It is private, and hence the viewable from inspector
    public float speed = 0;
    public Transform cam;
    public Transform scooter;

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        // Sets the value of rb by getting a reference of the Rigidbody component attached to the player sphere
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        cam.position = transform.position + new Vector3(.3f, -.3f, -1.6f);
        scooter.position = transform.position + new Vector3(0f, -.1f, -1f);
        //scooter.eulerAngles = new Vector3(scooter.eulerAngles.x, cam.eulerAngles.y, scooter.eulerAngles.z);
    }

    void OnMove(InputValue movementValue)
    {
        // gets vector2 value from the movement data and stores it in a vector2 variable called "movementVector"
        Vector2 movementVector = movementValue.Get<Vector2>();
        //Reference these values inside onMove and assign these values vectors x and y
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //f represents float value
        //since movement vector variable is created inside of OnMove, it is nonexistent in this context.
        //You can then combine the movement floats within the fixedupdate to create a vector3 variable
        //this will make 0 the y value (player moves across x and z axes in 3D space)
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        // you are not naming this Vector2 because this would be a Vector3 variable, which stores data across 3 axes
        //this is why you need to create 2 new variables to represent the additional directions
        rb.AddForce(movement * speed);
    }
}