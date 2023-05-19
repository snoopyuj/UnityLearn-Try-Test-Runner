using NSubstitute;
using NUnit.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

public class player_movement
{
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator with_positive_vertical_input_moves_forward()
    {
        var playerGo = new GameObject("Player");
        var player = playerGo.AddComponent<Player>();

        player.PlayerInput = Substitute.For<IPlayerInput>();
        player.PlayerInput.Vertical.Returns(1f);

        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(playerGo.transform);
        cube.transform.localPosition = Vector3.zero;

        yield return new WaitForSeconds(0.3f);

        var pos = player.transform.position;
        Assert.AreEqual(0, pos.x);
        Assert.AreEqual(0, pos.y);
        Assert.IsTrue(pos.z > 0f);
    }
}