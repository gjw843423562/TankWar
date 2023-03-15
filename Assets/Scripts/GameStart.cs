using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    public GameObject tankPrefab;
    public float time = 1;
    private Vector3 p;

    private Quaternion r;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        if (time >=0) {
            Vector3 p = new Vector3(Random.Range(-39, 39), 1, Random.Range(-39,39));
            Quaternion r = new Quaternion(0, Random.Range(0, 360), 0, 0);
            Instantiate(tankPrefab,p,r);
            time -= 100;
        }else
        {
            time++;
        }


    }


}
