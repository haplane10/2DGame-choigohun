using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    [SerializeField] private float defaultSpeed = 2.5f;
    private float speed;
    public float direction;
    private Animator animator;
    private PlayerController playerController;
    private bool isAttack = false;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();

        speed = defaultSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(playerController.transform.position, transform.position);
        
        if (distance <= 0.75f)
        {
            speed = 0f;
            animator.SetBool("isWalk", false);
            animator.SetTrigger("Attack");
        }
        else
        {
            speed = defaultSpeed;
            animator.SetBool("isWalk", true);
        }

        direction = playerController.transform.position.x - transform.position.x;
        direction = Mathf.Clamp(direction, -1, 1);
        rigidbody.velocity = new Vector2(speed * direction, rigidbody.velocity.y);

        if (isAttack == false)
        {
            animator.SetBool("isWalk", true);
        }
        
        // 캐릭터 뒤돌기
        if (direction > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


    }
}
