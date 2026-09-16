using UnityEngine;

public class WinCondition : MonoBehaviour
{
    private Transform player;
    private Transform goal;
    private float winPosition = Vector3.Position;
    Vector3 position = new Vector3(0, 0, 200f);
    private bool hasWon = false;

    void Update()
    {
        if (hasWon) return;
        float position = Vector3.Position(player.position, goal.position);

        if (position <= winPosition)
        {
            hasWon = true;
            WinGame();
        }

    }

    void WinGame()
    {
        Debug.Log("yay you made it");
    }
}