using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownManager : MonoBehaviour
{
    public int countdownIndex = 3;
    public bool gameStarted = false;
    public TextMeshProUGUI countdownText;

    void Start()
    {
        StartCoroutine(Countdown());
    }

    private IEnumerator Countdown()
    {
        countdownText.gameObject.SetActive(true);
        GetComponent<AudioSource>().Play();

        while (countdownIndex > 0)
        {
            countdownText.text = countdownIndex.ToString();

            yield return new WaitForSeconds(1);

            countdownIndex--;
        }

        countdownText.text = "GO";
        gameStarted = true;
        yield return new WaitForSeconds(1);
        countdownText.gameObject.SetActive(false);

        countdownIndex = 3;
    }

}
