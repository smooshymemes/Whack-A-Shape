using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : ClickableObject
{
	private readonly float despawnTime = 1.5f;
	private void Start()
	{
		StartCoroutine(DestroyAfterSeconds(despawnTime));
	}
	private IEnumerator DestroyAfterSeconds(float seconds)
	{
		yield return new WaitForSeconds(seconds);
		Destroy(gameObject);
	}
	
	//POLYMORPHISM
	protected override void OnMouseDown()
	{
		gameManager.DecreaseLives();
		Destroy(gameObject);
	}
	public void DestroyBombs()
	{
		Destroy(gameObject);
	}
}
