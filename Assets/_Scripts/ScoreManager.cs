using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    // public TextMeshProUGUI text;
    int score;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        Debug.Log(score);
        // text.text = score.ToString();
    }

    public void PowerUp()
    {
        instance.GetComponent<AudioSource>().pitch = 1.5f;
    }
}
