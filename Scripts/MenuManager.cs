using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	public void StartGame()
	{
		SceneManager.LoadScene(1);
	}
	public void QuitGame()
	{
#if UNITY_EDITOR
		EditorApplication.ExitPlaymode();
#else
Application.Quit();
#endif
	}
}