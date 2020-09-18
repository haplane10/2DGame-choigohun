using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int myForce;
    public int initialJumpPower;
    public bool playerJumped;
    public new Rigidbody2D rigidbody;

    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            rigidbody.MovePosition(new Vector2(transform.position.x + Input.GetAxis("Horizontal") * myForce * Time.deltaTime, transform.position.y));
        }

        if (Input.GetAxis("Jump") > 0)
        {
            playerJumped = true;
        }
    }

    void FixedUpdate()
    {
        if (playerJumped)
        {
            playerJumped = false;
            rigidbody.AddForce(new Vector2(0, initialJumpPower));
        }
    }
}
