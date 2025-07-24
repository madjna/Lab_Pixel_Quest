using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {
    public Transform respawnPoint;
    public string nextLevel = "GeoLevel_2";
    public int coinCount = 0;
    public int _health = 3;
    public int _maxHealth = 3;
    private PlayerUIContoller _playerUIContoller;

    private void Start()
    {
       _playerUIContoller = GetComponent<PlayerUIContoller>();
        _playerUIContoller.UpdateHealth(_health,_maxHealth);
    }

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
                        _playerUIContoller.UpdateHealth(_health, _maxHealth);
                        Destroy(other.gameObject);                   
                    }
                    break;
                }
                    
            case "Death":
            {
                    _health--;
                    _playerUIContoller.UpdateHealth(_health, _maxHealth);
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
            case "Respawn":
                {
                    respawnPoint.position = other.transform.Find("Point").position;
                    break;
                }
        }
    } 
}

