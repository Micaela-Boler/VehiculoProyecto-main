using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRotation : MonoBehaviour
{
    [SerializeField] float x;

    [SerializeField] float y;

    [SerializeField] float z;


    void Update()
    {
        x = transform.transform.localEulerAngles.x;
        y = transform.transform.localEulerAngles.y;

        if (Input.GetKeyDown(KeyCode.R))
            transform.eulerAngles = new Vector3(x, y, 0);
    }
}
