using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum CharacterType
{
    Penguin,
    Knight
}
[Serializable]
public class Character
{
    public CharacterType CharacterType;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController AnimatorContoroller;
}
public class GameManager : MonoBehaviour
{   
    public static GameManager instance;  
    public List<Character> characterList = new List<Character>();
    public Animator playerAnimator;
    public string playerName {get; private set;}
    public CharacterType characterType;
    void Awake()
    {  
        if (instance == null)//청므 생성이라면
            instance = this; //이것이 GameManager
         
        // 인스턴스가 이미 있는 경우 오브젝트 제거
        else if (instance != this) 
            Destroy(gameObject);
        DontDestroyOnLoad(this);
    }
    public void SetCharacter(CharacterType characterType)
    {
        playerAnimator = GameObject.Find("Player").GetComponentInChildren<Animator>();
        var character = characterList.Find(item => item.CharacterType == characterType);
        playerAnimator.runtimeAnimatorController = character.AnimatorContoroller;
    }
    public void SetName(string name)
    {
        playerName = name;
    }
}
