using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
	
	private GameManager gameManager;
	private void Start()
	{
		gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
	}
	private void OnMouseDown()
	{
		gameManager.numFruitsOnGrid--;
		Destroy(gameObject);
	}
}
