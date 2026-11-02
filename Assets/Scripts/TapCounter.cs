using TMPro;
using UnityEngine;

/// <summary>
/// Счётчик нажатий для мини-игры «Hello Tap».
/// Компонент висит на Canvas, кнопка «Тапни меня» вызывает Increment()
/// через событие OnClick, назначенное в инспекторе.
/// </summary>
public class TapCounter : MonoBehaviour
{
    // Текст (TMP), в который выводится счёт. Назначается в инспекторе.
    // В методичке используется UnityEngine.UI.Text, но на сцене стоит
    // Text (TMP), поэтому поле объявлено как TMP_Text.
    [SerializeField] private TMP_Text scoreText;

    // Текущее количество нажатий.
    private int count = 0;

    // Start вызывается один раз перед первым кадром: выводим начальный счёт.
    private void Start()
    {
        UpdateUI();
    }

    // Обработчик кнопки «Тапни меня»: увеличивает счёт на единицу.
    public void Increment()
    {
        count++;
        UpdateUI();
    }

    // Обнуляет счёт. Метод назван ResetScore, а не Reset, потому что Reset() —
    // служебный метод MonoBehaviour: редактор вызывает его при добавлении
    // компонента, когда scoreText ещё не назначен (это дало бы NullReferenceException).
    public void ResetScore()
    {
        count = 0;
        UpdateUI();
    }

    // Обновляет надпись со счётом на экране.
    private void UpdateUI()
    {
        scoreText.text = "Счёт: " + count;
    }
}
