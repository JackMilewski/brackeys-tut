using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float speed = 2000f;
    public float dodgespeed = 1000f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(dodgespeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-dodgespeed * Time.deltaTime, 0, 0);
        }

    }
}