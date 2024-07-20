using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class MyTest {
  [UnityTest]
  public IEnumerator MyTestWithEnumeratorPasses() {
    SceneManager.LoadScene("SampleScene");
    yield return new WaitForSeconds(3f);
  }
}
