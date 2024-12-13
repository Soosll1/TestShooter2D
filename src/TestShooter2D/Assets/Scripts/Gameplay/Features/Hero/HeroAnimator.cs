using UnityEngine;

namespace Gameplay.Features.Hero
{
    public class HeroAnimator : MonoBehaviour
    {
        private const string MoveHASH = "Move";
        private const string FireHASH = "Fire";

        [SerializeField] private Animator _animator;

        public void PlayMove(bool value)
        {
            if (_animator != null)
                _animator.SetBool(MoveHASH, value);
        }

        public void PlayShoot(bool value)
        {
            if (_animator != null)
                _animator.SetBool(FireHASH, value);
        }
    }
}