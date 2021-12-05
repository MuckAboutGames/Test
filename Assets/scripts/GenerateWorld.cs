using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GenerateWorld : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    private TileTypeListSo _tileTypeListSo;

    private void Awake()
    {
        _tileTypeListSo = Resources.Load<TileTypeListSo>(nameof(TileTypeListSo));
    }


    void Start()
    {
        for (int i=5; i<10; i++)
        {
            for(int j=5; j<10; j++)
            {
                //Instantiate at position () and zero rotation.
                Instantiate(SelectRandomTileType().tileSprite, new Vector2(i, j), Quaternion.identity);
            }
        }
    }

    private TileTypeSo SelectRandomTileType()
    {
        var randomIndex = UnityEngine.Random.Range(0f, _tileTypeListSo.list.Count);
        return _tileTypeListSo.list[(int) randomIndex];
    }
}
