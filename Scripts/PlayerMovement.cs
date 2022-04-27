using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;

    public Rigidbody2D Rb;

    Vector2 movement;

    void Update() // Update is called once per frame
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        Rb.MovePosition(Rb.position + movement * Speed * Time.fixedDeltaTime);
    }
}
