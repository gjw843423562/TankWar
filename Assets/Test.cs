using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    public GameObject go;
    public Transform tran;

    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {

        }
    }

    public void CreatBullet() {
        GameObject tempGo = Instantiate(go, tran.position, tran.rotation);
        tempGo.transform.GetComponentInChildren<Rigidbody>().AddForce(tran.forward * force);
    }
}
