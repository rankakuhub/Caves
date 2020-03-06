using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{
  
    public AudioSource audio;
    private bool hasPLayed = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            hasPLayed = true;
            Destroy(gameObject, 1f);
        }
        
    }
}
