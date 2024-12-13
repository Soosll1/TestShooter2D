using TMPro;
using UnityEngine;

namespace Gameplay.Features.UI.Behaviours
{
    public class PlayerHUD : MonoBehaviour
    {
        [SerializeField] private TMP_Text _ammoCount;

        public void SetCount(string value)
        {
            _ammoCount.text = value;
        }
    }
}