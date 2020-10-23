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
        float direction = Input.GetAxis("Horizontal");
        animator.SetFloat("Direction", direction);

        if (direction != 0)
        {
            animator.SetBool("Running", true);
            rigidbody.velocity = new Vector2(speed * direction, rigidbody.velocity.y);
        }
        else
        {
            animator.SetBool("Running", false);
        }

        if (isTile == true && Input.GetAxis("Jump") > 0)
        {
            isTile = false;
            rigidbody.AddForce(Vector2.up * jump);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // 내용 입력
        }
    }

    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector3.down, new Color(1, 0, 0));  // (0, -1, 0)
        RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, Vector3.down, 1, LayerMask.GetMask("Tile"));
        if (raycastHit.collider != null)
        {
            isTile = true;
            Debug.Log("충돌되었습니다.");
        }
    }

    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    if (isTile == false && collision.gameObject.CompareTag("Tile"))
    //    {
    //        isTile = true;
    //    }
    //}
}