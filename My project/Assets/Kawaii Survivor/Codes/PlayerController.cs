using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{   
    [Header("Elements")]
    [SerializeField] private MobileJoystick playerJoystick;
    [Header("Settings")]
    [SerializeField] private float moveSpeed;
    Rigidbody2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = Vector2.right;
    }

    // Update is called once per frame
    void Update() 
    {
        rb2.velocity = playerJoystick.GetMoveVector() * moveSpeed * Time.deltaTime;
    }
}
