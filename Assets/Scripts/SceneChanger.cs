using UnityEngine.SceneManagement;

public static class SceneChanger
{
    public static int SceneIndex = 1;

    public static void ChangeScene()
    {
        SceneIndex++;
        SceneManager.LoadScene(SceneIndex);
    }
}