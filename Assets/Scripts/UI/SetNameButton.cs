using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNameButton : MonoBehaviour
{
    [SerializeField] GameObject changeName;

    public void OnClickSetName()
    {
        if(changeName.activeSelf == false)
            changeName.SetActive(true);
        else
            changeName.SetActive(false);
    }
}
