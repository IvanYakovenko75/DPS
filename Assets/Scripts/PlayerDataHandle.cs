using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    //Статический класс для сохранения данных текущего игрока;
    //Одноэлементный шаблон

    public static PlayerDataHandle Instance;

    public string PlayerName;
    public int Score;

    private void Awake()
    {
        // на самом деле нам не нужен этот оператор if, потому что, когда мы находимся в основной сцене,
        // мы не можем вернуться в сцену меню «Пуск», где уже существует объект дескриптора данных игрока.
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
