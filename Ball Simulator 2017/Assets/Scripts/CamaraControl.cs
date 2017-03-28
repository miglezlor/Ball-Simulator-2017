using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour {

    public GameObject pelota;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - pelota.transform.position;
    }

    void LateUpdate()
    {
        transform.position = pelota.transform.position + offset;
    }
}
