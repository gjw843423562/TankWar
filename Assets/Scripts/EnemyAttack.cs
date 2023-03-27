using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {
    public GameObject ShellPrefab;
    public float shellSpeed = 10;
    public AudioClip shotAudio;
    private Transform firePosition;
    private Transform goE;
    private float timer = 1;
    public Test test;
    
    // Start is called before the first frame update
    void Start() {
        firePosition = transform.root.Find("FirePosition");
        goE = transform.root;
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerStay(Collider other) {
        if (other.tag == "Player") {
           // goE.LookAt(other.transform.position);
           if (timer <= 0) {
               AudioSource.PlayClipAtPoint(shotAudio,transform.position);
               test.CreatBullet();
               // test.CreatBullet(firePosition.position, ShellPrefab, firePosition.position, firePosition.rotation);
               // GameObject go = Instantiate(ShellPrefab,firePosition.position,firePosition.rotation,firePosition) ;
               // go.transform.localPosition = Vector3.zero;
               // go.transform.localRotation = Quaternion.identity;
               // go.GetComponent<Rigidbody>().AddForce(firePosition.forward * shellSpeed);
               timer = 1;
           }
           timer -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
           
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
           
        }
    }
}
