using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RunStrategy : IMovementStrategy
{
    public void Move()
    {
        Debug.Log("Running");
    }
}
