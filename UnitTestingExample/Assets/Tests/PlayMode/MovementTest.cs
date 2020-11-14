using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MovementTest
    {
        [UnityTest]
        public IEnumerator MovementWithEnumeratorPasses()
        {
            GameObject player = new GameObject();
            PlayerInput inputs = player.AddComponent<PlayerInput>();

            inputs.MoveLeft();

            yield return new WaitForSeconds(1);

            Assert.AreEqual(player.transform.position, new Vector3(-1, 0, 0));
        }
    }
}
