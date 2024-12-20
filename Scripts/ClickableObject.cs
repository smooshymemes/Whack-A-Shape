using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//IHERITANCE
public abstract class ClickableObject : MonoBehaviour
{
	protected GameManager gameManager;
	private void Awake()
	{
		gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
	}
	protected abstract void OnMouseDown();
	private void Update()
	{
		if (gameManager.gameIsOver)
		{
			Destroy(gameObject);
		}
	}

}
