using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/TileType")]
public class TileTypeSo : ScriptableObject
{
    public string nameString;
    public bool isFarmable;
    public Transform tileSprite;
}
