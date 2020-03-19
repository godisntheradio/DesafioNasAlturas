using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerManager : Manager
{
    #region Serialized Field

    [SerializeField]
    private ReviveScoreScreen ReviveScoreScreen;

    #endregion

    public int PointsToRevive = 0;
    public int PointsRequiredToRevive = 2;
    public bool HasDeadPlayer = false;
    public void TryRevive()
    {
        if(HasDeadPlayer)
        {
            PointsToRevive++;
            ReviveScoreScreen.UpdateText(PointsRequiredToRevive - PointsToRevive);
            if (PointsToRevive >= PointsRequiredToRevive)
            {
                Revive();
                HasDeadPlayer = false;
            }
        }
    }
    public void PlayerHasDied(Camera playerCamera)
    {
        if (HasDeadPlayer)
        {
            EndGame();
            ReviveScoreScreen.Hide();
        }
        else
        {
            HasDeadPlayer = true;
            PointsToRevive = 0;
            ReviveScoreScreen.Show(playerCamera, PointsRequiredToRevive);
        }
    }
    private void Revive()
    {
        foreach (Player item in FindObjectsOfType<Player>())
        {
            item.Activate();
        }
        ReviveScoreScreen.Hide();
    }
    public override void Restart()
    {
        base.Restart();
        HasDeadPlayer = false;
        PointsToRevive = 0;
        ReviveScoreScreen.Hide();
    }
}
