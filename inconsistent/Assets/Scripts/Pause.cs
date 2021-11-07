using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
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
				AudioListener.pause = true;
			}
			else if (Time.timeScale == 0)
			{
				Debug.Log("unpause");
				Time.timeScale = 1;
				AudioListener.pause = false;
			}
		}

		if (Input.GetKeyDown(KeyCode.R))
		{
			Restart();
		}
	}

	// Restarts current level
	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	// load other level
	public void LoadLevel(string level)
	{
		SceneManager.LoadScene(level);
	}
}
