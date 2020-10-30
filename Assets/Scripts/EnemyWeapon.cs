using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        collision.GetComponent<PlayerController>().animator.SetInteger("Animation", 5);
        var playerRigidbody = collision.GetComponent<Rigidbody2D>();
        playerRigidbody.velocity = new Vector2(collision.GetComponent<PlayerController>().direction * 2f, playerRigidbody.velocity.y);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        var playerRigidbody = collision.GetComponent<Rigidbody2D>();
        playerRigidbody.velocity = new Vector2(collision.GetComponent<PlayerController>().direction * 2f, playerRigidbody.velocity.y);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.GetComponent<PlayerController>().animator.SetInteger("Animation", 0);
    }
}
