using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(2.2f, 0f, 0f);
    }
}
