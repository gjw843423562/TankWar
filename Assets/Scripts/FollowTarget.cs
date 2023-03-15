using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform Player1;
    public Transform Player2;

    private Vector3 offset;

    private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - (Player1.position + Player2.position) / 2;
        _camera = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1 ==null || Player2 == null)
        {
            return;
        }
        transform.position = (Player1.position + Player2.position) / 2 + offset;
        float distance = Vector3.Distance(Player1.position, Player2.position);
        float size = distance * 0.5f;
        if (_camera.orthographicSize>=10)
        {
            _camera.orthographicSize = size;
        }
    }
}
