using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//POLYMORPHISM
public abstract class ClickableObject : MonoBehaviour
{
	
	protected GameManager gameManager;
	private void Start()
	{
		gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
	}
	protected abstract void OnMouseDown();
	

}
