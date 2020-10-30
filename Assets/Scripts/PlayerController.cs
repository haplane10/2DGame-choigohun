using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;

    public float speed;
    public float jump;
    public new Rigidbody2D rigidbody;

    public bool isTile;
    public float direction;

    //int A, B = 30, C = 70;

    //int Add(int D, int E)
    //{
    //    return D + E;
    //}

    // Start is called before the first frame update
    void Start()
    {
        //A = Add(B, C);
        //Debug.Log(A);
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Direction", direction);

        if (direction != 0)
        {
            if (isTile)
            {
                animator.SetInteger("Animation", 2);
            }
            rigidbody.velocity = new Vector2(speed * direction, rigidbody.velocity.y);
            transform.localScale = new Vector3(direction, 1, 1);
        }
        
        if (isTile && Input.GetAxis("Jump") > 0)
        {
            rigidbody.AddForce(Vector2.up * jump);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            animator.SetInteger("Animation", 4);
        }
    }

    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector3.down, new Color(1, 0, 0));  // (0, -1, 0)
        RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, Vector3.down, 1, LayerMask.GetMask("Tile"));
        if (raycastHit.collider != null)
        {
            isTile = true;
            animator.SetInteger("Animation", 1);
            Debug.Log("충돌되었습니다.");
        }
        else
        {
            isTile = false;
            animator.SetInteger("Animation", 3);
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Tile"))
    //    {
    //        animator.SetInteger("Animation", 0);
    //    }
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Tile"))
    //    {
    //        animator.SetInteger("Animation", 3);
    //    }
    //}
}