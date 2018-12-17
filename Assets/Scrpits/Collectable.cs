using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;
    private static int soulCount = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            soulCount++;
            Debug.Log("Coin count:" + soulCount);
            audioSource.Play();
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;
            //Destroy(gameObject,audioSource.clip.length);
        }
    }
}
