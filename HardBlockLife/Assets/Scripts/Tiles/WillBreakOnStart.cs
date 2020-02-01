using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WillBreakOnStart : MonoBehaviour
{

    public float _totalTimeToLive = 0f;
    private bool _timerOn = true;

    void Update()
    {
        if (_timerOn)
        {
            _totalTimeToLive -= Time.deltaTime;
            if (_totalTimeToLive > 0)
                return;
            Break();
        }
    }

    public void SetTimeAndStart(float time)
    {
        _totalTimeToLive = time;
        _timerOn = true;
    }
    public void Start()
    {
        SetTimeAndStart(5f);
    }
    public void Break()
    {
        var rigidBody = gameObject.AddComponent<Rigidbody>();
        if(rigidBody != null && transform.parent != null)
            rigidBody.AddExplosionForce(350f, transform.parent.transform.position, 1000f);
        var timeToLive = gameObject.AddComponent<TimeToLive>();
        timeToLive.SetTimeAndStart(5f);
        var explosion = GameObject.Find("Explosion").GetComponent<AudioSource>();
        if(!explosion.isPlaying)
            explosion.Play();
        GameObject.Find("Music").GetComponent<AudioSource>().enabled = true;
    }
}
