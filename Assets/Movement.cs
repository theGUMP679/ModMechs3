using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //speed
    public float speed = 10f;
    Vector2 lastClickedPos;
    //defnes move or not
    bool moving;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //
        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        // if moving and not at same pos, then move
        if(moving && (Vector2)transform.position != lastClickedPos)
        {
            //only move through created delta time
            float step = speed * Time.deltaTime;
            //where we are vs where we want to go
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);

        } else
        {
            //no more movement
            moving = false;
        }
    }
}
