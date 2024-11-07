using UnityEngine;
using UnityEngine.SceneManagement;


namespace mandy.Tools
{
    /// <summary>
    /// 場景控制器，提供載入場警和退出遊戲的功能
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="scenename">要載入的場景名稱</param>
        public void LoadScence(string scenename)
        {
            //場景管理器 的 載入場警(場景名稱)
            SceneManager.LoadScene(scenename);
        }

        /// <summary>
        /// 退出遊戲
        /// </summary>
        public void QuitGame()
        {
            //應用程式 的 離開()
            Application.Quit();
        }

    }
}

