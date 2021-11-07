using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsClicked : MonoBehaviour
{
    [SerializeField] private AudioClip clip = null;

    private void OnMouseDown()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
        SceneManager.LoadScene(0);
    }
}
