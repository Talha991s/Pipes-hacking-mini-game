using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 5f;
    float timerLeft;

    public GameObject GameOver;
    public GameObject pipes;

    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Image>();
        timerLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerLeft > 0)
        {
            timerLeft -= Time.deltaTime;
            timerBar.fillAmount = timerLeft / maxTime;

        }
        else
        {
            
            GameOver.SetActive(true);
            Destroy(pipes);
            //Time.timeScale = 0;
        }
    }
}
