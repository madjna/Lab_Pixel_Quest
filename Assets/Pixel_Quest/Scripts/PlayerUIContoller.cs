using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class PlayerUIContoller : MonoBehaviour
{
    public Image HeartImage;

    // Start is called before the first frame update
    public void Start()
    {
        HeartImage = GameObject.Find("HeartImage").GetComponent<Image>();
    }

    // Update is called once per frame
    public void UpdateHealth(float currentHealth, float maxHealth) 
    {
        HeartImage.fillAmount = currentHealth / maxHealth;
    }
}
