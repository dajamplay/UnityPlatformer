using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    void Start()
    {
        PlayerEventsList.onTest += Test;

    }

    void Test()
    {
        Debug.Log("I debugger!");
    }
}
