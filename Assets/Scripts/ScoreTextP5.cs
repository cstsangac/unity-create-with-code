using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextP5 : MonoBehaviour
{
  public static TextMeshProUGUI self;
  // Start is called before the first frame update
  void Start()
  {
    if (self != null)
    {
      Debug.LogError("More than one " + nameof(ScoreTextP5) + " is created!");
    }
    self = GetComponent<TextMeshProUGUI>();
  }
}
