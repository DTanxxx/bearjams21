using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitClicked : MonoBehaviour
{
    private void OnMouseDown()
    {
        Application.Quit(0);
    }
}
