using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : ClickableObject
{
	private readonly int pointValue = 10;
	//POLYMORPHISM
	protected override void OnMouseDown()
	{
		gameManager.numFruitsOnGrid--;
		gameManager.IncreaseScore(pointValue);
		Destroy(gameObject);
	}
	
}
