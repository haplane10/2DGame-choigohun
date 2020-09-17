using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;

    public float speed;
    public new Rigidbody2D rigidbody;

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
            rigidbody.velocity = new Vector2(speed * direction, 0);

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

        if (Input.GetAxis("Jump") > 0)
        {
            rigidbody.AddForce(Vector2.up * 10);
        }

        

        if (Input.GetKey(KeyCode.A))
        {
            // 내용 입력
        }

    }
}
