using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyStrategy : IMovementStrategy
{
    public void Move()
    {
        Debug.Log("Flying");
    }
}
