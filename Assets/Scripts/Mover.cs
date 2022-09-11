using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    #region Variables
    // Ill do the hungarian notation but im not going to like it.
    [SerializeField] private float fltXVal = 0.02f;
    [SerializeField] private float fltYVal = 0f;
    [SerializeField] private float fltZVal = 0f;
    #endregion

    #region Unity Methods

    void Start()
    {
        //transform.Translate(0.01f, 0, 0);
    }

    void Update()
    {
        MovePlayer();
    }

    #endregion

    #region Private Methods
    private void MovePlayer()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        // bool jumpInput = Input.GetButtonDown("Jump");
        float jumpspeed = 5f;
        float speed = 5f;

        transform.Translate(input.x * speed * Time.deltaTime, 0, input.y * speed * Time.deltaTime);
    }
    #endregion

    #region Public Methods

    #endregion
}
