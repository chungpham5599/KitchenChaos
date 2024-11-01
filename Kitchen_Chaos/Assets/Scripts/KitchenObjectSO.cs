using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class KitchenObjectSO : ScriptableObject
{
    [SerializeField] private Transform prefab;
    public Transform GetPrefab()
    {
        return prefab;
    }
    [SerializeField] private String objectName;
    public String GetObjectName()
    {
        return objectName;
    }

    [SerializeField] private Sprite sprite;
    public Sprite GetSprite()
    {
        return sprite;
    }

}
