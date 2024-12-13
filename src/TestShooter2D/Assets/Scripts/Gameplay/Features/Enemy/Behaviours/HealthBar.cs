using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Features.Enemy.Behaviours
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Image _healthBar;

        public void Set(float current, float max)
        {
            gameObject.SetActive(true);

            _healthBar.fillAmount = current / max;
        }
    }
}