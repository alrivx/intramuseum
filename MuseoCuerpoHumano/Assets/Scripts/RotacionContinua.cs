using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionContinua : MonoBehaviour
{
    public float speed = 15.0f;
    [Space()]
    public float rotateX = 0.0f;
    public float rotateY = 1.0f;
    public float rotateZ = 0.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(rotateX, rotateY, rotateZ);
        rotation *= (speed * Time.deltaTime);
        transform.Rotate(rotation);
    }
}
