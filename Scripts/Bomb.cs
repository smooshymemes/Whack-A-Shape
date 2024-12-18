using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : ClickableObject
{
    //POLYMORPHISM
    protected override void OnMouseDown()
    {
        gameManager.numFruitsOnGrid--;
        gameManager.lives--;
        Debug.Log("Player Lost 1 Life");
        if (gameManager.lives == 0)
        {
            gameManager.GameOver();
        }

        Destroy(gameObject);
    }
}
