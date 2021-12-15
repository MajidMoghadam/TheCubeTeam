﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.localScale = GetRandomSize();
        }
    }

    private Vector3 GetRandomSize()
    {
        return new Vector3(UnityEngine.Random.Range(0.5f, 1.5f),
                        UnityEngine.Random.Range(0.5f, 1.5f),
                        UnityEngine.Random.Range(0.5f, 1.5f));
    }
}
