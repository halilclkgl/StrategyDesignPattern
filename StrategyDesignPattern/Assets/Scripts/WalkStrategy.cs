    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

public class WalkStrategy :  IMovementStrategy
    {
        public void Move()
        {
            Debug.Log("Walking");
        }
    }