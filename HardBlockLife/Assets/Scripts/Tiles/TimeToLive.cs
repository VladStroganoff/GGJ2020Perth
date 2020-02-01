using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToLive : MonoBehaviour
{
    public float _totalTimeToLive = 0f;
    private bool _timerOn = false;

    void Update()
    {
        if(_timerOn)
        {
            _totalTimeToLive -= Time.deltaTime;
            if (_totalTimeToLive > 0)
                return;
            DestroyTheObject();
        }
    }

    public void SetTimeAndStart(float time)
    {
        _totalTimeToLive = time;
        _timerOn = true;
    }

    private void DestroyTheObject()
    {
        Destroy(gameObject);
    }
}
