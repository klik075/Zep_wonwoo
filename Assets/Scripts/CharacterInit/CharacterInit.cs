using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInit : MonoBehaviour
{
    public static CharacterInit instance;
    [SerializeField]private Text playerText;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        GameManager.instance.SetCharacter(GameManager.instance.characterType);  
        playerText.text = GameManager.instance.playerName;
    }
    public void SetName(string inputName)
    {
        GameManager.instance.SetName(inputName); //게임매니저의 캐릭터 이름 변경
        playerText.text = GameManager.instance.playerName;//텍스트를 player로
        Debug.Log("이름 변경");
    }
}
