using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public int spinSpeed;
    public Vector3 RotateAmount;
    // Start is called before the first frame update
    void Start()
    {
        spinSpeed = 1;
        RotateAmount = new Vector3(0.0f, 250.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount * Time.deltaTime / spinSpeed);
    }
}
