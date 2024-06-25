using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject victoryScreen;
    [SerializeField] GameObject player;

    [Header("KILLS")]
    [SerializeField] int killQuantityTarget;
    [SerializeField] int killCounter;
    [SerializeField] Text kills;

    [Header("SCORE")]
    [SerializeField] Text scoreText;
    int pointQuantity;



    void Start()
    {
        victoryScreen.SetActive(false);

        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (player == null)
            ChangeScene(0);
    }



    public void KillCounter()
    {
        killCounter++;
        kills.text = "Kills: " + killCounter;

        if (killCounter >= killQuantityTarget)
            Win();
    }

    private void Win()
    {
        victoryScreen.SetActive(true);
        Time.timeScale = 0;
    }


    public void ChangeScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }



    // EVENT //

    public void UpdateScore(int pointValue)
    {
        pointQuantity += pointValue;
        scoreText.text = "Score: " + pointQuantity;
    }

    private void OnEnable()
    {
        Point.point += UpdateScore;
    }

    private void OnDisable()
    {
        Point.point -= UpdateScore;
    }
}
