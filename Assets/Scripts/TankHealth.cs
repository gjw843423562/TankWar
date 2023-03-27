using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {
    public int HP = 100;
    public int MinATK = 10;
    public int MaxATK = 20;
    public GameObject tankExplosion;
    public AudioClip tankExplosionAudio;
    public Slider HpSlider;

    private int hpTotal;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        hpTotal = HP;
    }

    void TakeDamage(){
        if (HP <= 0) {
            
            return;
        }
        HP -= Random.Range(MinATK, MaxATK);
        HpSlider.value = (float)HP/ hpTotal;
        if (HP<=0) {
            AudioSource.PlayClipAtPoint(tankExplosionAudio,transform.position);
            Instantiate(tankExplosion, transform.position, transform.rotation);
            if (gameObject.tag == "Enemy") {
                GameStart gs = new GameStart();
                gs.DelEnemy(gameObject.tag);
            }
            else {
                Debug.Log("你已死亡");
            }
          
            Destroy(gameObject);
        }
    }
}
