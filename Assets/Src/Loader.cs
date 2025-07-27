using UnityEngine.SceneManagement;

public static class Loader
{
    public enum Scene
    {
        GameScene,
        MainMenuScene,
    }

    public static Scene targetScene;

    public static void Load(Scene targetScene)
    {
        Loader.targetScene = targetScene;
        LoaderCallback();
    }

    public static void LoaderCallback()
    {
        SceneManager.LoadScene(targetScene.ToString());
    }
}
