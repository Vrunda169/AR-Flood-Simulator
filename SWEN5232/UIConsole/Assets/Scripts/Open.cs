using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Open : MonoBehaviour
{

    public GameObject Panel;

    public void OpenProject()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);

            Debug.Log("Hey! You're trying to open a file");
        }

    }
}
