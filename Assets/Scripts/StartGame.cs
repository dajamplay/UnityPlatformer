using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    void Start()
    {
        PlayerEventsList.onTest?.Invoke();
    }

    void Update()
    {
        
    }
}
