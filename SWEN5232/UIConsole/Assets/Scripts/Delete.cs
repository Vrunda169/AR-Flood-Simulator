using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delete : MonoBehaviour
{

    [SerializeField]
    GameObject objectToDestroy;
    public void DestroyGameObject()
    {
        //Destroy Game object
        Destroy(objectToDestroy);

        Debug.Log("I am deleting a model!");
    }
}
