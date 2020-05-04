using System.Collections;
using UnityEngine;
using Bolt;

[BoltGlobalBehaviour]
public class NetworkCallbacks : GlobalEventListener
{
  public override void SceneLoadLocalDone(string scene)
  {
    // Your code here...

    //randomize a position
    var spawnPosition = new Vector3(Random.Range(-8, 8), 0, Random.Range(-8, 8));

    //instantiate cube
    BoltNetwork.Instantiate(BoltPrefabs.TutorialBox, spawnPosition, Quaternion.identity);
  }
}
