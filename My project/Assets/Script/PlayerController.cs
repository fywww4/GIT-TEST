using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [Header("������V")]
    public float moveX;

    [Header("������V")]
    public float moveY;

    [Header("���O")]
    public float push;

    Rigidbody2D rb2D;

    [Header("���Ƥ�rUI")]
    public Text CountText;

    [Header("�q����rUI")]
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
        CountText.text = "�ثe����" + score.ToString();
        if (score >= 12)
        {
            WinText.text = "�zĹ�F!!!";
        }
    }
}
