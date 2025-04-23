using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [Header("水平方向")]
    public float moveX;

    [Header("垂直方向")]
    public float moveY;

    [Header("推力")]
    public float push;

    Rigidbody2D rb2D;

    [Header("分數文字UI")]
    public Text CountText;

    [Header("通關文字UI")]
    public Text WinText;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        WinText.text = "";
        SetScoreText();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        rb2D.AddForce(push * movement);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            score += 1;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        CountText.text = "目前分數" + score.ToString();
        if (score >= 12)
        {
            WinText.text = "您贏了!!!";
        }
    }
}
