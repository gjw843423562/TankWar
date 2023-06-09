using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour{
    public GameObject player;
    public GameObject enemyPrefab;
    public int EnemyCount = 1;
    public float time = 1;
    private Vector3 enemyPosition;
    private Vector3 enemyRotatio;
    private Vector3 playerPosition;
    private Vector3 playerRotatio;
    private int EnemyCountNow = 0;
    private bool playerIsDead = true;
    private float DeadTime = 0;
    // Start is called before the first frame update
    void Start() {

        playerPosition = new Vector3(-2, 1, 20);
        playerRotatio= new Vector3(0, Random.Range(0, 360), 0);
        
    }

    // Update is called once per frame
    void Update() {
        AddPlayer();
        AddEnemy();
    }

    void AddPlayer() {
        if (playerIsDead &&DeadTime<=0) {
          Instantiate(player,playerPosition,Quaternion.Euler(playerRotatio));
          DeadTime = 5;
          playerIsDead = false;
        }else if (playerIsDead &&DeadTime>0) {
            DeadTime -= Time.deltaTime;
        }
    }
    
    
    void AddEnemy(){
        if (EnemyCountNow==EnemyCount ) {
            return;
        }
        enemyPosition = new Vector3(Random.Range(-39, 39), 1, Random.Range(-39,39));
        enemyRotatio= new Vector3(0, Random.Range(0, 360), 0);
        if (time >1) {

            Instantiate(enemyPrefab,enemyPosition,Quaternion.Euler(enemyRotatio));
            EnemyCountNow++;
            time = 0;
        }else {
            time+=Time.deltaTime;
        }
    }

    public void DelEnemy(string Tag) {
        if (Tag == "Player") {
            playerIsDead = true;
        }
        else if (Tag == "Enemy") {
            EnemyCountNow--;
        }
        
    }

}
