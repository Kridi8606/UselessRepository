using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Player : Character
{
    private void Start()
    {
        Vector2Int currentCell = Map.grid.GetCell2D(this.gameObject);
        transform.position = Map.grid.GetCellCenter2D(currentCell);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Move.Move(Direction.Left);
        }
    }
}
