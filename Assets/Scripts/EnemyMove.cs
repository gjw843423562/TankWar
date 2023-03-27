using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {
    public Vector3 destination;

    private NavMeshAgent nav;
    // Start is called before the first frame update
    void Start() {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update() {
       // EnemyMoving();
    }


    public void EnemyMoving() {
        if (nav.destination==null||(transform.position - nav.destination).magnitude<=2) {
            nav.destination = RomDestination();
        }
    }

    public Vector3 RomDestination() {
        float romX = Random.Range(transform.position.x - 20, transform.position.x + 20);
        float romY = 1f;
        float romZ = Random.Range(transform.position.z - 20, transform.position.z + 20);
        return new Vector3(romX, romY, romZ);
    }
}
