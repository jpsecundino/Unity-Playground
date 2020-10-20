using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class UpdateGraph : MonoBehaviour
{
    public float time = 0f;
    public float threshold= 3f;
    

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= threshold){
            time = 0;
            var graphToScan = AstarPath.active.data.gridGraph;
            AstarPath.active.Scan(graphToScan);
        }
    }   
}
