using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public Animator animator;

    public float speed;
    public float jump;
    public new Rigidbody2D rigidbody;

    public bool isTile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        if (direction != 0)
        {
            animator.SetBool("Running", true);
            rigidbody.velocity = new Vector2(speed * direction, rigidbody.velocity.y);

            if (direction > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        else
        {
            animator.SetBool("Running", false);
        }

        if (isTile == true && Input.GetAxis("Jump") > 0)
        {
            isTile = false;
            rigidbody.AddForce(Vector2.up * jump);
            animator.SetBool("Jumping", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // 내용 입력
        }

    }

    //private void FixedUpdate()
    //{
    //    rigidbody.AddForce(Physics.gravity * rigidbody.mass);
    //}

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (isTile == false && collision.gameObject.CompareTag("Tile"))
        {
            isTile = true;
            animator.SetBool("Jumping", false);
        }
    }
}
