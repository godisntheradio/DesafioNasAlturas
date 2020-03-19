using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerManager : Manager
{

    public int PointsToRevive = 0;
    public int PointsRequiredToRevive = 2;
    public bool HasDeadPlayer = false;
    public void TryRevive()
    {
        if(HasDeadPlayer)
        {
            PointsToRevive++;
            if (PointsToRevive >= PointsRequiredToRevive)
            {
                Revive();
                HasDeadPlayer = false;
            }
        }
    }
    public void PlayerHasDied()
    {
        if (HasDeadPlayer)
        {
            EndGame();
        }
        HasDeadPlayer = true;
        PointsToRevive = 0;
    }
    private void Revive()
    {
        foreach (Player item in FindObjectsOfType<Player>())
        {
            item.Activate();
        }
    }
    public override void Restart()
    {
        base.Restart();
        HasDeadPlayer = false;
        PointsToRevive = 0;
    }
}
