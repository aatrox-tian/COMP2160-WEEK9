﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter2D(Collider2D collision)
    {
		  //if picked by player
        if (collision.gameObject.tag == "Player")
        {
            //get score
            score++;
            //change score into text
            text.text = score.ToString();
            //destroy itself
            Destroy();
        }
}
}
