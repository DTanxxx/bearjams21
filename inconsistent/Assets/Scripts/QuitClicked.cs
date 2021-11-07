using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitClicked : MonoBehaviour
{
    [SerializeField] private AudioClip clip = null;

    private void OnMouseDown()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
        Application.Quit(0);
    }
}
