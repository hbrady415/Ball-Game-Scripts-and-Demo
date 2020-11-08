using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float speed;
    public Text countText;
    public bool isOver;
    private Rigidbody rb;
    private int count;
    public float jumpHeight = 7f;
    public bool isGrounded;
    private int count2;

    // Start is called before the first frame update
    void Start()
    {
        isOver = false;
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
        if (isGrounded)
        {
            if (Input.GetButtonDown("Jump") && count2==0)
            {
                count2 = 1;
                rb.AddForce(Vector3.up * jumpHeight);
            }
        }
        if (isOver && Input.GetButtonDown("R"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            count2 = 0;
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Ground"))
        {
            print("changed it");
            count2 = 0;
            isGrounded = true;
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count>=10)
        {
            countText.text = "YOU WIN!!!! Press R to restart";
            isOver = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
