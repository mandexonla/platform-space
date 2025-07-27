using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button MainMenuButton;

    public static MainMenu Instance;

    private void Awake()
    {
        MainMenuButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.MainMenuScene);
        });
        Instance = this;
    }
}
