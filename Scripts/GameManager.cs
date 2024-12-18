using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public int health = 3;
	private float fruitSpawnInterval = 0.25f;
	private float fruitSpawnDelay = 1f;
	public bool gameIsOver = false;
	public GameObject[] fruitPrefabs;
	private GameObject fruitPrefab;
	private int row;
	private int numRows = 5;
	private int col;
	private int numCols = 5;
	public float fruitSpacing = 2f;
	private float spawnPosX;
	private float spawnPosY;
	public int numFruitsOnGrid = 0;
	public GameObject planePrefab;
	public int score = 0;
	public int lives = 3;
	// Start is called before the first frame update
	void Start()
	{
		
		//start the fruit spawning
		InvokeRepeating("SpawnFruit", fruitSpawnDelay, fruitSpawnInterval);
	}

	private void SpawnFruit()
	{
		if (!gameIsOver && numFruitsOnGrid < 4)
		{
			//choose a random fruit prefab from the list avaliable
			fruitPrefab = fruitPrefabs[Random.Range(0, fruitPrefabs.Length - 1)];
			//instantiate a fruit
			Instantiate(fruitPrefab, GenerateFruitPosition(), fruitPrefab.transform.rotation);
			numFruitsOnGrid++;
		}
	}
	private Vector3 GenerateFruitPosition()
	{
		row = Random.Range(0, numRows - 1);
		col = Random.Range(0, numCols - 1);
		spawnPosX = fruitSpacing * (row - 2);
		spawnPosY = fruitSpacing * (col - 2);
		return new Vector3(spawnPosX, spawnPosY, 0);
	}
	

}
