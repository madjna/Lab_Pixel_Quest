using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class PlayerUIContoller : MonoBehaviour
{
    public Image HeartImage;
    private TextMeshProUGUI _text;

    // Start is called before the first frame update
    public void StartUI()
    {
        HeartImage = GameObject.Find("HeartImage").GetComponent<Image>();
        _text = GameObject.Find("CoinText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
   
    public void UpdatText(string newText) { _text.text = newText; }
    public void UpdateHealth(float currentHealth, float maxHealth) 
    {
        HeartImage.fillAmount = currentHealth / maxHealth;
    }
}
