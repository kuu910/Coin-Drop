using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s: MonoBehaviour
{
    public CoinManager CoinManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "coin")
        {
            Destroy(other.gameObject);
            CoinManager.coin++;
        }
    }
}
