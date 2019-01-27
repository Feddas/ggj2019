using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetWhenObjectFalls : MonoBehaviour
{
    [Tooltip("If the y value is less than this, the level resets")]
    public float MinYValue;

    void Start()
    {
    }

    void Update()
    {
        if (this.transform.localPosition.y < MinYValue)
        {
            HomeThings.CoinsGathered = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
