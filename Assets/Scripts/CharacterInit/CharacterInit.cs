using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInit : MonoBehaviour
{
    [SerializeField]private Text playerText;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.SetCharacter(GameManager.instance.characterType);  
        playerText.text = GameManager.instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
