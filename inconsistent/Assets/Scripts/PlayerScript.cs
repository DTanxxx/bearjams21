using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private BoxCollider2D myFeet = null;
    [SerializeField] private KeyCode[] keyCodes = new KeyCode[3];

    private Rigidbody2D body;
    private BoxCollider2D myCollider;
    public float speed;
    public float jumpHeight;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<BoxCollider2D>();
        keyCodes[0] = KeyCode.LeftArrow;
        keyCodes[1] = KeyCode.UpArrow;
        keyCodes[2] = KeyCode.RightArrow;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Die();
    }

    private void Move()
    {
        if (keyCodes[0] == KeyCode.LeftArrow && keyCodes[2] == KeyCode.RightArrow)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                body.velocity = new Vector2(-speed, body.velocity.y);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                body.velocity = new Vector2(speed, body.velocity.y);
            }
            else
            {
                body.velocity = new Vector2(0, body.velocity.y);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")) &&
                !myFeet.IsTouchingLayers(LayerMask.GetMask("Platforms")))
                {
                    return;
                }
                body.velocity = new Vector2(body.velocity.x, jumpHeight);
            }
        }
        else if (keyCodes[0] == KeyCode.RightArrow && keyCodes[2] == KeyCode.LeftArrow)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                body.velocity = new Vector2(speed, body.velocity.y);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                body.velocity = new Vector2(-speed, body.velocity.y);
            }
            else
            {
                body.velocity = new Vector2(0, body.velocity.y);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")) &&
                !myFeet.IsTouchingLayers(LayerMask.GetMask("Platforms")))
                {
                    return;
                }
                body.velocity = new Vector2(body.velocity.x, jumpHeight);
            }
        }
        else if (keyCodes[0] == KeyCode.LeftArrow && keyCodes[1] == KeyCode.RightArrow)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                body.velocity = new Vector2(-speed, body.velocity.y);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                body.velocity = new Vector2(speed, body.velocity.y);
            }
            else
            {
                body.velocity = new Vector2(0, body.velocity.y);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")) &&
                !myFeet.IsTouchingLayers(LayerMask.GetMask("Platforms")))
                {
                    return;
                }
                body.velocity = new Vector2(body.velocity.x, jumpHeight);
            }
        }
        else if (keyCodes[0] == KeyCode.RightArrow && keyCodes[1] == KeyCode.LeftArrow)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                body.velocity = new Vector2(speed, body.velocity.y);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                body.velocity = new Vector2(-speed, body.velocity.y);
            }
            else
            {
                body.velocity = new Vector2(0, body.velocity.y);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")) &&
                !myFeet.IsTouchingLayers(LayerMask.GetMask("Platforms")))
                {
                    return;
                }
                body.velocity = new Vector2(body.velocity.x, jumpHeight);
            }
        }
        else if (keyCodes[1] == KeyCode.LeftArrow && keyCodes[2] == KeyCode.RightArrow)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                body.velocity = new Vector2(-speed, body.velocity.y);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                body.velocity = new Vector2(speed, body.velocity.y);
            }
            else
            {
                body.velocity = new Vector2(0, body.velocity.y);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")) &&
                !myFeet.IsTouchingLayers(LayerMask.GetMask("Platforms")))
                {
                    return;
                }
                body.velocity = new Vector2(body.velocity.x, jumpHeight);
            }
        }
        else if (keyCodes[1] == KeyCode.RightArrow && keyCodes[2] == KeyCode.LeftArrow)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                body.velocity = new Vector2(speed, body.velocity.y);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                body.velocity = new Vector2(-speed, body.velocity.y);
            }
            else
            {
                body.velocity = new Vector2(0, body.velocity.y);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")) &&
                !myFeet.IsTouchingLayers(LayerMask.GetMask("Platforms")))
                {
                    return;
                }
                body.velocity = new Vector2(body.velocity.x, jumpHeight);
            }
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

    public void SwitchControl()
    {
        Debug.Log("SWITCH!");
        KeyCode[] temp = new KeyCode[3];
        int randomIndex = Random.Range(0, 2);
        temp[0] = keyCodes[randomIndex];
        temp[randomIndex] = keyCodes[0];
        
        if (randomIndex == 1)
        {
            temp[2] = keyCodes[2];
        }
        else if (randomIndex == 2)
        {
            temp[1] = keyCodes[1];
        }
        else
        {
            temp[1] = keyCodes[2];
            temp[2] = keyCodes[1];
        }
        keyCodes = temp;
    }
}
