using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] public TextMeshPro coinText;

    public int coin;
    private int coins = 150;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= coins; i++)
        {
            float x = UnityEngine.Random.Range(-6, 3);
            float y = UnityEngine.Random.Range(2, 15);
            float z = UnityEngine.Random.Range(-3, 3);
            Instantiate(coinPrefab, new Vector3(x, y, z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(coin > 0)
            {
                float x = UnityEngine.Random.Range(-4, 0);
                float y = 3;
                float z = UnityEngine.Random.Range(-2, 2);
                Instantiate(coinPrefab, new Vector3(x, y, z), Quaternion.identity);
                coin--;
            }
            Debug.Log(coin);
        }
        string str = coin.ToString();
        coinText.text = str;
    }
}
