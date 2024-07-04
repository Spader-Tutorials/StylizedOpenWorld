using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    public float rotationSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
