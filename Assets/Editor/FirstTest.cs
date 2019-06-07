using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.TestTools;
using NUnit.Framework;

public class FirstTest
{
    
    [Test]
    public void DoesItWork()
    {
        bool variable = false;
        Assert.AreEqual(false, variable);
    }

}
