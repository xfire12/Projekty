﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour
{
    public SpriteRenderer door;
    public Sprite doorOpen;
    public Sprite mySprite;

    private SpriteRenderer toggle;


    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnTriggerEnter2D(Collider2D other)
   {
       if(other.gameObject.tag =="player")
        {
            toggle.sprite = mySprite;
            door.sprite = doorOpen;
           


        }



    }




}
