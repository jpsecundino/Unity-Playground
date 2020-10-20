using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class SoldierTest : MonoBehaviour
{
    public Collider2D c;
    void Update()
    {
        var guo = new GraphUpdateObject(c.bounds); 
        AstarPath.active.UpdateGraphs(guo);
    }
}
