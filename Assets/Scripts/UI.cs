using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public TMP_Text TimerText;
    public TMP_Text CubeCounttext;
    float CountdownTimer = 120f;
    public GameObject Gameoverpanel;

    private void Start()
    {
        Gameoverpanel.SetActive(false);
    }
    private void Update()
    {
        if (CountdownTimer >= 0)
        {
            CountdownTimer -= Time.deltaTime;

            float min = Mathf.FloorToInt(CountdownTimer / 60);
            float Sec = Mathf.FloorToInt(CountdownTimer % 60);
            TimerText.text = string.Format("{0,00}:{1,00}", min, Sec);
        }
        if(CountdownTimer<=0)
        {
            Gameoverpanel.SetActive(true);
            TimerText.gameObject.SetActive(false);
            CubeCounttext.gameObject.SetActive(false);
            Time.timeScale = 0f;
        }
        
    }
    public void ReplyBtnClicked()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitBtnClicked()
    {
        Application.Quit();
    }
}