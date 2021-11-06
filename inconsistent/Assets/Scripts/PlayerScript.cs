using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private BoxCollider2D myFeet = null;

    private Rigidbody2D body;
    private BoxCollider2D myCollider;
    public float speed;
    public float jumpHeight;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        Die();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(x * speed, body.velocity.y);
    }

    void Jump()
    {
        if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")) &&
            !myFeet.IsTouchingLayers(LayerMask.GetMask("Platforms"))) { return; }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Player jumps!");
            body.velocity += new Vector2(body.velocity.x, jumpHeight);
        }
    }

    void Die()
    {
        if (myCollider.IsTouchingLayers(LayerMask.GetMask("Hazards")) ||
            myFeet.IsTouchingLayers(LayerMask.GetMask("Hazards")))
        {
            FindObjectOfType<GameSession>().ProcessPlayerDeath();
        }
    }
}
