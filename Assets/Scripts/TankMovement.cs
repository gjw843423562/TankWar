using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 5;
    public float angularSpeed =30;
    public float number = 1;
    public AudioClip idleAudio;
    public AudioClip dringAudio;
    private AudioSource _audioSource;
    private Rigidbody _rigidbody;
    void Start()
    {
        _audioSource = GetComponent("AudioSource") as AudioSource;
        _rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (number ==0)
        {
            return;
        }
        float h = Input.GetAxis("HorizontalPlayer"+number);
        if (h != 0) {
            _rigidbody.angularVelocity = transform.up * h * angularSpeed;
        }

        float v = Input.GetAxis("VerticalPlayer"+number);
        if (v != 0) {
            _rigidbody.velocity = transform.forward * v * speed;
        }

        if (Mathf.Abs(h) >0.1 || Mathf.Abs(v) >0.1)
        {
            _audioSource.clip = dringAudio;
            if (_audioSource.isPlaying == false)
            {
                _audioSource.Play();
            }
        }
        else {
            _audioSource.clip = idleAudio;
            if (_audioSource.isPlaying == false)
            {
                _audioSource.Play();
            }
        }
    }
}
