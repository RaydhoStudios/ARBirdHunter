using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;
    //public int health = 100;
    private int damage = 8;
    public Healthbar healthbar;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.setMaxHealth(maxHealth);
    }

    private void OnCollisionEnter(Collision _collision)
    {
         //Debug.Log(health);
        if(_collision.gameObject.tag == "enemy" && currentHealth>0)
        {
            //print("contact" + health);
            currentHealth -= damage;
            healthbar.setHealth(currentHealth);
            anim.SetTrigger("blood");
            Destroy(_collision.gameObject);
        }
        else if( currentHealth <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
