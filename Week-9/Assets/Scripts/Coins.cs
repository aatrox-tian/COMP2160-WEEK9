using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
    {
		  //if picked by player
        if (collision.gameObject.tag == "Player")
        {
            ScoreKeeper sc = GameObject.FindGameObjectWithTag("ScoreKeeper").GetComponent<ScoreKeeper>();
            //get score
            sc.PickUpCoin();
            //destroy itself
            Destroy(gameObject);
        }
}
}
