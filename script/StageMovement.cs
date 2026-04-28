using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float sin = Mathf.Sin( Time.time );
        float x = -3;
        float y = 1;
        float z = 0;
        this.transform.position = new Vector3(sin*x, y,  z );
    }
}
