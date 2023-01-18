using UnityEngine;
using UnityEngine.UI;

public class RestartButtonP5 : MonoBehaviour
{

  public static GameObject obj;

  Button btn;
  // Start is called before the first frame update
  void Start()
  {
    if (obj != null)
    {
      Debug.LogError("More than one " + this.GetType().Name + " is created!");
    }
    obj = gameObject;
    obj.SetActive(false);

    btn = GetComponent<Button>();
    btn.onClick.AddListener(() => GameManagerP5.RestartGame());
  }




}
