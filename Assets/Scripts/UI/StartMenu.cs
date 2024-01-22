using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Image characterSprite;
    [SerializeField] private InputField inputField;
    [SerializeField] private GameObject information;
    [SerializeField] private GameObject selectCharacter;
    private CharacterType characterType;
    private string playerName;//플레이어 이름
    public void OnClickSelectCharacter(int index) //캐릭터 선택 이미지 변경
    {
        GameManager.instance.characterType = (CharacterType)index;
        var character = GameManager.instance.characterList.Find(item => item.CharacterType == GameManager.instance.characterType);
        characterSprite.sprite = character.CharacterSprite;
        characterSprite.SetNativeSize();

        selectCharacter.SetActive(false);
        information.SetActive(true);
    }
    public void OnClickCharacter()
    {
        information.SetActive(false);
        selectCharacter.SetActive(true);
    }
    public void OnClickJoin()
    {
        if(!(2 <= inputField.text.Length && inputField.text.Length <= 10))
        {
            return;
        }

        playerName = inputField.text;
        GameManager.instance.SetName(playerName);//플레이어 네임 설정
        SceneManager.LoadScene("MainScene");
    }
}
