using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text score;
    public Text endScore;

    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = player.score.ToString();
    }

    public void SetEndScore()
    {
        endScore.text = "Final Score: " + player.score.ToString();
    }
}
