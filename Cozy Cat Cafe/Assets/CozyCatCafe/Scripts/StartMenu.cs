using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CozyCatCafe.Scripts
{
    public class StartMenu : MonoBehaviour
	{
		
		public SaveSystem Save;

		public Button QuitButton;

		public Button gotoTutorial;

		public TutorialMenu tutorialMenu;


		private void Awake()
		{

			gotoTutorial.onClick.AddListener(() => tutorialMenu.Confirm());
#if UNITY_WEBGL
			QuitButton.interactable = false;
#endif
		}


		public void NewGamePressed()
		{
			tutorialMenu.tutorialPopUp.SetActive(true);
			SoundMaster.Play(SoundMaster.Type.Menu);
			Save.Reset();
			
		}

		public void ContinuePressed()
		{
			SoundMaster.Play(SoundMaster.Type.Menu);
			Save.Load();
			SceneManager.LoadScene(1);
		}

		public void QuitPressed()
		{
			SoundMaster.Play(SoundMaster.Type.Menu);
#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBGL
			Debug.Log("Can't just quit in web");
#else
			Application.Quit();
#endif
		}
	}
}