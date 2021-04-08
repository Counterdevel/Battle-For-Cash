using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCorrida : MonoBehaviour
{
    public static GameManagerCorrida Instance;
    public Vector3 lastcheckpointPos;
    
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }
}
