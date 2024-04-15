using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public static Grid grid { get; private set; }

    private void Awake()
    {
        grid = FindObjectOfType<Grid>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
