using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int totalPins = 10;
    int cazute = 0;
    public ParticleSystem strikeEffect;

    void Start() { UpdateText(); }

    public void PinCade()
    {
        cazute++;
        UpdateText();
    }

    void UpdateText()
    {
        scoreText.text = "Popice cazute:  " + cazute + " / " + totalPins;
        if (cazute >= totalPins)
        {
            scoreText.text += "\nSTRIKE!";
            if (strikeEffect != null) strikeEffect.Play();
        }
    }
}
