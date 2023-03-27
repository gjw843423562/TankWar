using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject shellExplosionPrefab;

    public AudioClip shellExplosionAudio;
    // Start is called before the first frame update


    public void OnTriggerEnter(Collider collider) {
        if (collider.tag == "TTT") {
            return;
        }
        AudioSource.PlayClipAtPoint(shellExplosionAudio,transform.position);
        Instantiate(shellExplosionPrefab, transform.position, transform.rotation);
        
        Destroy(gameObject);
        if (collider.tag == "Player"||collider.tag == "Enemy") {
            collider.SendMessage("TakeDamage");
        }
    }
}
