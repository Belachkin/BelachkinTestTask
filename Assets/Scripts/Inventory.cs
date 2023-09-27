using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    
    public static Inventory Instance;

    public Action onChange;

    [SerializeField] private int _space;
    
    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        Instance = this;
    }

    public List<Item> Items = new List<Item>();

    public void Add(Item item)
    {
        if(Items.Count >= _space)
        {
            Debug.Log("Инвентарь переполнен");
            return;
        }

        Items.Add(item);

        onChange?.Invoke();
    }
    public void Remove(Item item)
    {
        Items.Remove(item);
    }
}
