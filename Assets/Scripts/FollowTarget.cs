using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {
    private Transform player;
    //玩家和相机的差
    private Vector3 offset; 
    //相机移动速度
    private float speed = 3;

    // Start is called before the first frame update
    void Start() {
        
        
    }

    // 更新相机位置
    void LateUpdate() {
        if ( player == null) {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            offset = transform.position - player.position;
        }
        //世界坐标转化为局部坐标
        Vector3 targetPosition = player.position + player.TransformDirection(offset);
        //移动相机
        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
        //相机看向玩家的方向
        transform.LookAt(player.position);
    }
}
