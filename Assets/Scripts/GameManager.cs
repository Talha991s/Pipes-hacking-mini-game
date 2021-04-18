using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject PipeHolder;
    public GameObject[] Pipes;

    [SerializeField]int totalPipes =0;
    [SerializeField] public int totalmoves = 7;
    [SerializeField] public int currentmove = 1;

    [SerializeField] private TMP_Text movetext;
    [SerializeField] private TMP_Text totaltext;

    public GameObject WinScreen;
    public GameObject LoseScreen;

    public GameObject pipes;

    [SerializeField]int correctedPipes = 0;
    // Start is called before the first frame update
    void Start()
    {
        totaltext.text = totalmoves.ToString();
 
        totalPipes = PipeHolder.transform.childCount;

        Pipes = new GameObject[totalPipes];
        
        for(int i =0; i< Pipes.Length; i++)
        {
            Pipes[i] = PipeHolder.transform.GetChild(i).gameObject;
        }
    }

    public void correctMove()
    {
        correctedPipes += 1;
        Debug.Log("Correc move");
        if(correctedPipes == totalPipes)
        {
            WinScreen.SetActive(true);
        }
    }

    public void wrongMove()
    {
        correctedPipes -= 1;
    }

    public void numofmoves()
    {

        movetext.text = currentmove.ToString();
        currentmove += 1;
        if(currentmove == 8)
        {
            LoseScreen.SetActive(true);
            Destroy(pipes);
        }
    }
}
