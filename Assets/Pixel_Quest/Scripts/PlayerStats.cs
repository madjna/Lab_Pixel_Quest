using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {
    public Transform respawnPoint;
    public string nextLevel = "GeoLevel_2";
    public int coinCount = 0;
    public int _health = 3;


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Health":
                {
                    if (_health < 3)
                    {
                        _health++;
                        Destroy(other.gameObject);                   
                    }
                    break;
                }
                    
            case "Death":
            {
                    _health--;
                    if (_health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    else
                    {
                        transform.position = respawnPoint.position;                        
                    }
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

