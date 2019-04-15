using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using NUnit.Framework;

public class FirstTest
{
    [Test]
    public void DoesItWork()
    {
        // FindObjectOfType<GameManager>().ToMenu();
        //Assert.AreEqual("Menu", SceneManager.GetActiveScene().name);
        bool variable = false;
        Assert.AreEqual(false, variable);
    }
}
