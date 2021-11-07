using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestroyer : MonoBehaviour
{
    [SerializeField] private float movementRate = 5f;

    private void Update()
    {
        transform.position += new Vector3(movementRate * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<GameSession>().ProcessPlayerDeath();
        }
    }
}
