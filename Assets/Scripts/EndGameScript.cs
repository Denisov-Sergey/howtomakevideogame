using System;
using UnityEngine;

public class EndGameScript : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.EndGame();
    }
}
