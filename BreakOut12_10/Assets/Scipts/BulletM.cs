﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletM : MonoBehaviour
{
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall"||collision.gameObject.tag=="Stick")
        {
            Destroy(this.gameObject);
        }
    }
}
