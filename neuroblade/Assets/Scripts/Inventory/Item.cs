using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SlotTag { None, Eatable, Food, Paper, Knife,}

[CreateAssetMenu(menuName = "ScriptableObjects/Item")]
public class Item : ScriptableObject
{
    public Sprite sprite;
    public SlotTag itemTag;

    [Header("If the item can be equipped")]
    public GameObject equipmentPrefab;
}