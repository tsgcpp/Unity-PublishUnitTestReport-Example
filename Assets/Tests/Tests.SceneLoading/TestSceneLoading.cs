using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests.SceneLoading
{
    public class TestSceneLoading
    {
        [UnityTest]
        public IEnumerator LoadScene_Passed_SampleSceneCanBeLoaded()
        {
            yield return SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Single);
            var activeScene = SceneManager.GetActiveScene();

            Assert.That(activeScene.path, Is.EqualTo("Assets/Scenes/SampleScene.unity"));
            Assert.That(activeScene.GetRootGameObjects().Length, Is.EqualTo(3));
        }

        [UnityTest]
        public IEnumerator LoadScene_Passed_EmptyCanBeLoaded()
        {
            // Failure result example (because Empty.unity is not added into "Scenes in Build")

            yield return SceneManager.LoadSceneAsync("Empty", LoadSceneMode.Single);
            var activeScene = SceneManager.GetActiveScene();

            Assert.That(activeScene.path, Is.EqualTo("Assets/Scenes/Empty.unity"));
            Assert.That(activeScene.GetRootGameObjects().Length, Is.Zero);
        }
    }
}
