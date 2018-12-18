using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    public AudioSource hazardAudioSource;
    private void Start()
    {
        hazardAudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Player entered Hazard");
            PlayerCharacter player = collision.GetComponent<PlayerCharacter>();
            hazardAudioSource.Play();
            player.isHurt = true;
            
            player.Respawn();
           
        }
        else
        {
            Debug.Log("Something other than Player entered Hazard");
        }
    }

}
