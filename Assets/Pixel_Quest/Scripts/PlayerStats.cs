using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {
    public string nextLevel = "GeoLevel_2";
    public int coinCount = 0;
    public int Health = 3;


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Health":
            {
                Health++;
                Destroy (other.gameObject);
                break;

            }
            case "Death":
            {
                string thisLevel = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(thisLevel);
                break;
            }
            case "Finish":
            {
                SceneManager.LoadScene(nextLevel);
                break;
            }
            case "Coin":
                {
                    coinCount++;
                    Destroy(other.gameObject);
                    break;
                }
        }
    } 
}

