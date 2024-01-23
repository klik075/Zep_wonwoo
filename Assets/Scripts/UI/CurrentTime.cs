using System;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    [SerializeField] private Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowCurrentTime();
    }
    public void ShowCurrentTime()
    {
        timeText.text = DateTime.Now.ToString(("HH:mm"));  
    }
}
