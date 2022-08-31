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
        transform.Translate(fltXVal, fltYVal, fltZVal);
    }

    #endregion

    #region Private Methods

    #endregion

    #region Public Methods

    #endregion
}
