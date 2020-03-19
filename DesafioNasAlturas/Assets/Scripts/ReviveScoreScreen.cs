using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReviveScoreScreen : MonoBehaviour
{
    #region Serialized Fields

    [SerializeField]
    private Text ScoreText;
    [SerializeField]
    private Canvas Canvas;

    #endregion

    private void Awake()
    {
        
    }

    public void Show(Camera playerCamera, int requiredScore)
    {
        this.gameObject.SetActive(true);
        Canvas.worldCamera = playerCamera;
        UpdateText(requiredScore);
    }
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
    public void UpdateText(int score)
    {
        ScoreText.text = score.ToString();
    }

}
