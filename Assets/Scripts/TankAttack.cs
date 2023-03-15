using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour
{
    
    public KeyCode fireKey = KeyCode.Space; 
    public GameObject ShellPrefab;
    public float shellSpeed = 10;
    public AudioClip shotAudio;
    private Transform firePosition;
        // Start is called before the first frame update
    void Start()
    {
        firePosition = transform.Find("FirePosition");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(fireKey)) {
            AudioSource.PlayClipAtPoint(shotAudio,transform.position);
            GameObject go = Instantiate(ShellPrefab,firePosition.position,firePosition.rotation) ;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
        }
    }
}
