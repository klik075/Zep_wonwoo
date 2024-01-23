using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    [SerializeField] private InputField inputField;

    public void OnClickChange()
    {
        if(!(2 <= inputField.text.Length && inputField.text.Length <= 10))
        {
            return;
        }
        CharacterInit.instance.SetName(inputField.text); //캐릭터 이름 변경
        gameObject.SetActive(false);
    }
}
