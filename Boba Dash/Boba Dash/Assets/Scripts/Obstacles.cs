using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField]
    private AudioClip hit;

    [SerializeField]
    private int move_speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-move_speed * Time.deltaTime, 0f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SoundManager.PlaySFX(hit);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Despawn")) //if objects enter despawner
        {
            Destroy(gameObject);
        }

    }
}
