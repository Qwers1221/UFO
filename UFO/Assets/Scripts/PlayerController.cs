using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;
    int bitcoin;
    public Text textBitcoin; // текстовое поле для вивода очков биткоина
    public int HP;
    public Text textHP;
    private bool gameOver;
    public Image imgGameOver;
    public Image imgWinner;
    public int maxCoins = 5;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        bitcoin = 0;
        textBitcoin.text = System.Convert.ToString(bitcoin);
        textHP.text = System.Convert.ToString(HP);
        gameOver = false;
        imgGameOver.gameObject.SetActive(false);
        imgWinner.gameObject.SetActive(false);
	}

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
        //Когда жизни закончелись
        if (HP <= 0) {
            gameOver = true;
            Time.timeScale = 0;
            imgGameOver.gameObject.SetActive(true);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            other.gameObject.SetActive(false);
            bitcoin = bitcoin + 1;
            textBitcoin.text = System.Convert.ToString(bitcoin);
            if (bitcoin >= maxCoins)
            {
                gameOver = true;
                Time.timeScale = 0;
                imgWinner.gameObject.SetActive(true);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pregrada"))
        {
            HP = HP - 10;
            textHP.text = System.Convert.ToString(HP);
        }
    }

}
