using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recupscorelvl2 : MonoBehaviour
{
    public GameObject sphere;
    private int Scoreofplayer;
    private Text printScore;
    
    void Update()
    {
        //Recupere le score dans le script du joueur pour l'afficher
        Scoreofplayer = sphere.GetComponent<player>().score;
        printScore = GetComponent<Text>();
        printScore.text = Scoreofplayer.ToString();
    }
}
