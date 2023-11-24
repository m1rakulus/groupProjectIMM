using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI goldCount;
    public GameObject titleScreen;
    public UnityEngine.UI.Button button;

    public int difficulty;

    public bool isGameActive;
    // Start is called before the first frame update

    public void StartGame()
    {
        isGameActive = true;
        titleScreen.SetActive(false);

    }
    public void Start()
    {
        button.onClick.AddListener(() => StartGame());
    }
}
