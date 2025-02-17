﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartClicked : MonoBehaviour
{
    [SerializeField] private AudioClip clip = null;

    private void OnMouseDown()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);       
    }
}
