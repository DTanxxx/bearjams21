using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpUp : MonoBehaviour
{
    public float jumpIncrease = 2f;
    private PolygonCollider2D myCollider;
    public AudioClip pickup;
    public AudioSource audio;

    public GameObject player;
    public PlayerScript playerScript;

    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<PolygonCollider2D>();
        audio = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<PlayerScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(pickup, transform.position);
            playerScript.jumpHeight += jumpIncrease;
            Destroy(gameObject);
        }
    }
}
