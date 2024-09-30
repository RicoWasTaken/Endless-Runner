using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampSpawner : MonoBehaviour
{
    public GameObject lampPrefab;

    public Vector2 coinOffset = new Vector2(0, 1);

    void Start()
    {
        SpawnCoin();
    }

    // Update is called once per frame
    void SpawnCoin()
    {
        Vector3 coinPosition = transform.position + (Vector3)coinOffset;

        Instantiate(lampPrefab, coinPosition, Quaternion.identity);
    }
}
