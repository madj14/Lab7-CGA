using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ergebe : MonoBehaviour
{
    Light lt;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float timeLamp = Time.fixedTime;
        if(timeLamp % 1.0f == 0)
        {
            lt.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
}
