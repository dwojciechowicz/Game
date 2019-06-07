using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Tests
{
    public class NewTestScript
    {
        private ForwardMotion pm;
        private Rigidbody player;
        [SetUp]
        public void SetUp()
        {
          //  player = Rigidbody.Instantiate(new Rigidbody());
        }
        [UnityTest]
        public IEnumerator GameScenePlatformTag()
        {
            SceneManager.LoadScene("Level1");
            yield return new WaitForSeconds(1);
            var plane = GameObject.FindGameObjectWithTag("Floor");
            Assert.AreEqual("Floor", plane.tag);
        }
        [UnityTest]
        public IEnumerator MenuSceneCanvasOn()
        {
            SceneManager.LoadScene("Menu");
            yield return new WaitForSeconds(2);
            // var text = GameObject.Find("Information").GetComponent<Canvas>();
            Canvas []text = GameObject.FindObjectsOfType<Canvas>();
            Assert.AreEqual(true, text[0].isActiveAndEnabled);
          //  Assert.AreEqual(false, text.activeSelf);
        }
        [UnityTest]
        public IEnumerator GameSceneThereIsAPlayer()
        {
            SceneManager.LoadScene("Level1");
            var play = GameObject.FindGameObjectWithTag("Player");
            Assert.AreEqual("Player", play.tag);
            yield return null;
        }
        [UnityTest]
        public IEnumerator GameScenePlayerHasPosition()
        {
            SceneManager.LoadScene("Level1");
            Vector3 playe = GameObject.FindGameObjectWithTag("Player").transform.position;
            Assert.AreEqual(0.0f,playe.z);
            yield return null;
        }
        [UnityTest]
        public IEnumerator LoadingMySceneWorks()
        {
            ToLevelScene tls = new ToLevelScene();
            tls.ToLevel1();
            Assert.AreEqual("Level1",SceneManager.GetActiveScene().name);
            yield return null;
        }
        [UnityTest]
        public IEnumerator LoadingSceneWorks()
        {
            SceneManager.LoadScene("Menu");
            yield return new WaitForSeconds(1);
            Assert.AreEqual("Menu", SceneManager.GetActiveScene().name);
        }
      /*  [UnityTest]
        public IEnumerator GameSceneGameStartsPlayerMoves()
        {
            SceneManager.LoadScene("Level1");
           var player = GameObject.FindGameObjectWithTag("Player");
            Vector3 position = player.transform.position;
            yield return new WaitForSeconds(1);
            Vector3 newposition = player.transform.position;
            Assert.AreNotEqual(position,newposition);
        }
        */
        [TearDown]
        public void TearDown()
        {
       //     GameObject.Destroy(player);
        }
    }
}
