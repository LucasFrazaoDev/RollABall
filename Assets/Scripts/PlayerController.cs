using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0f;

    private Rigidbody playerRig;
    private UIControllerGame uiControllerGame;
    [SerializeField] private Transform respawnPoint;

    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        playerRig = GetComponent<Rigidbody>();
        uiControllerGame = GameObject.Find("UIControllerGame").GetComponent<UIControllerGame>();
    }

    private void Update()
    {
        if (transform.position.y < -20)
        {
            transform.position = respawnPoint.position;
            playerRig.velocity = Vector3.zero;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        playerRig.AddForce(movement * speed);
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.CompareTag("Pickup"))
        {
            target.gameObject.SetActive(false);

            uiControllerGame.Count++;
            uiControllerGame.IncreaseCount();
        }
    }
}
