using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
	GameObject[] pauseObjects;
	GameObject[] finishObjects;

	// Start is called before the first frame update
	void Start()
	{
		Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update()
	{

		//uses the p button to pause and unpause the game
		if (Input.GetKeyDown(KeyCode.P))
		{
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
			}
			else if (Time.timeScale == 0)
			{
				Time.timeScale = 1;
			}
		}
	}

	//Reloads the Level
	public void Reload()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	//loads inputted level
	public void LoadLevel(string level)
	{
		SceneManager.LoadScene(level);
	}
}
