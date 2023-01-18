using UnityEngine;

public class GameOverTextP5 : MonoBehaviour
{
  public static GameObject obj;
  // Start is called before the first frame update
  void Start()
  {
    if (obj != null)
    {
      Debug.LogError("More than one " + nameof(GameOverTextP5) + " is created!");
    }
    obj = gameObject;
    gameObject.SetActive(false);
  }
}
