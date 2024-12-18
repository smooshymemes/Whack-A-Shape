using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnClick : DestroyOnClick
{
	private GameManager gameManager;
	// Start is called before the first frame update
	private void Start()
	{
		gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
	}
	private void OnMouseDown()
	{
		gameManager.lives--;
	}
}
