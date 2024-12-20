using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public int health = 3;
	private readonly float fruitSpawnInterval = 0.25f;
	private readonly float fruitSpawnDelay = 1f;
	public bool gameIsOver = false;
	public GameObject[] fruitPrefabs;
	private readonly int numRows = 5;
	private readonly int numCols = 5;
	public float fruitSpacing = 2f;
	public int numFruitsOnGrid = 0;
	public int score = 0;
	public TextMeshProUGUI scoreText;
	public int lives = 3;
	public TextMeshProUGUI livesText;
	
	// Start is called before the first frame update
	void Start()
	{
		
		//start the fruit spawning
		InvokeRepeating(nameof(SpawnFruit), fruitSpawnDelay, fruitSpawnInterval);
	}
	
	private void SpawnFruit()
	{
		if (!gameIsOver && numFruitsOnGrid < 4)
		{
			//choose a random fruit prefab from the list avaliable
			int fruitPrefabIndex = Random.Range(0, fruitPrefabs.Length - 1);
			GameObject fruitPrefab = fruitPrefabs[fruitPrefabIndex];
			
			//instantiate a fruit
			Instantiate(fruitPrefab, GenerateFruitPosition(), fruitPrefab.transform.rotation);
			
			numFruitsOnGrid++;
		}
	}
	private Vector3 GenerateFruitPosition()
	{
		//determine the row and column that the fruit will spawn in randomly
		int row = Random.Range(0, numRows - 1);
		int col = Random.Range(0, numCols - 1);
		//use that information to determine the x and y coordinates
		float spawnPosX = fruitSpacing * (row - 2); //-2 over here is kinda sketchy but im short on time rn
		float spawnPosY = fruitSpacing * (col - 2);
		Vector3 spawnPos = new(spawnPosX, spawnPosY, 0);
		return spawnPos;
	}
	public void GameOver()
	{
		gameIsOver = true;
		Debug.Log("Game Over!");
		//gameOverText.setActive(true);
	}
	public void IncreaseScore(int scoreIncrease)
	{
		Debug.Log("Player Gained 10 Points");
		score += scoreIncrease;
		UpdateScoreText();
	}
	private void UpdateScoreText()
	{
		scoreText.text = "Score: " + score;
	}
	//ABSTRACTION (best example)
	public void DecreaseLives()
	{
		lives--;
		UpdateLivesTextColor();
		UpdateLivesText();
		if (lives == 0)
		{
			GameOver();
		}
	}
	private void UpdateLivesTextColor()
	{
		if (lives <= 1)
		{
			livesText.color = Color.red;
		}
		else
		{
			livesText.color = Color.black;
		}
	}
	private void UpdateLivesText()
	{
		livesText.text = "Lives: " + lives;
	}
}

