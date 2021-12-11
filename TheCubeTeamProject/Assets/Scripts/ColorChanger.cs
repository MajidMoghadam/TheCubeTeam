using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            GetComponent<Renderer>().material.color = GetRandomColor();
        }
    }

    private Color GetRandomColor()
    {
        return new Color(UnityEngine.Random.Range(0,1f),
                        UnityEngine.Random.Range(0, 1f),
                        UnityEngine.Random.Range(0, 1f));
    }
}
