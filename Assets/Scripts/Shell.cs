using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject shellExplosionPrefab;

    public AudioClip shellExplosionAudio;
    // Start is called before the first frame update


    public void OnTriggerEnter(Collider collider)
    {
        AudioSource.PlayClipAtPoint(shellExplosionAudio,transform.position);
        Instantiate(shellExplosionPrefab, transform.position, transform.rotation);
        
        GameObject.Destroy(this.gameObject);
        if (collider.tag == "Tank")
        {
            collider.SendMessage("TakeDamage");
        }
    }
}