using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : Component
{
    public Lamp() : base(1) {}

    public override bool Process()
    {
        return inputs[0] != null && inputs[0].IsActive();
    }
}
