using TMPro;
using UnityEngine;

public class NumberRandomizer : MonoBehaviour
{
    public TMP_Text numberText;
    private int randomNumber;

    public void RandomizeNumber()
    {
        randomNumber = Random.Range(0, 5);
        numberText.text = randomNumber.ToString();
    }
}
