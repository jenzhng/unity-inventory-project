using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;

namespace Tests
{
    public class TestSuite: InputTestFixture
{
    GameObject playerPrefab = Resources.Load<GameObject>("Player");
    Mouse mouse;
    Keyboard keyboard;

    public override void Setup()
    {
        base.Setup();
        mouse = InputSystem.AddDevice<Mouse>();
        keyboard = InputSystem.AddDevice<Keyboard>();
    }

    [Test]
    public void CheckInventoryOpens()
    {

        Press(keyboard.tabKey);
    }

    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        var go = new GameObject();
        go.AddComponent<Rigidbody>();
        var originalPosition = go.transform.position.y;
        
        yield return new WaitForFixedUpdate();

        Assert.AreNotEqual(originalPosition, go.transform.position.y);
        }
}
}
