using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class Soldier : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject initPos;

    public bool init = false; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0,0);

        if(initPos != null){
            transform.position = initPos.transform.position;
        }
    }
}
