using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWorld : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    void Start()
    {
        for (int i=5; i<10; i++)
        {
            for(int j=5; j<10; j++)
            {
                // Instantiate at position () and zero rotation.
                Instantiate(myPrefab, new Vector2(i, j), Quaternion.identity);
            }
        }
    }
}
