﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 Direction = mousePos - transform.position;
        rb.velocity = new Vector2(Direction.x, Direction.y) * 4;
    }

    // Update is called once per frame
    void Update()
    {

    }
}