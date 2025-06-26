using UnityEngine;
using TMPro;

public class TextTimerController : MonoBehaviour
{
    public TextMeshPro timerText;  // Assign your TextMeshProUGUI in Inspector
    public float timer = 300f;        // Start from 5 minutes (300 seconds)
    public InjectionSafetyCheck injectionSafetyCheck; // Reference to the InjectionSafetyCheck script
    public float DeathTime = 720f; // 12 minutes in seconds
    void Update()
    {
        if (injectionSafetyCheck != null && !injectionSafetyCheck.isSafe)
        {
        

            timer += Time.deltaTime;

            // Show timer in mm:ss format until "Death"
            if (timer < DeathTime)
            {
                int minutes = Mathf.FloorToInt(timer / 60f);
                int seconds = Mathf.FloorToInt(timer % 60f);
                timerText.text = $"{minutes:00}:{seconds:00}";
            }

            // Color transition: Green (5 min) to Red (10 min)
            if (timer <= 600f)
            {
                float t = Mathf.InverseLerp(300f, 600f, timer); // from 0 to 1
                timerText.color = Color.Lerp(Color.green, Color.red, t);
            }


            // After 12 minutes: show "Death" 
            if (timer >= 720f)
            {
                timerText.text = "Death";
                timerText.color = Color.red;
            //   Debug.Log("Death");
            }
        }
        else
        {
            timerText.text = "Healing";
            timerText.color = Color.green; // Optional: change color to indicate healing
        }
    }
}

