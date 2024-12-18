using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : ClickableObject
{
	//POLYMORPHISM
	protected override void OnMouseDown()
	{
		gameManager.numFruitsOnGrid--;
		Debug.Log("Player Gained 10 Points");
		Destroy(gameObject);
	}
}
