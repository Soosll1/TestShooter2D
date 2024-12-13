using UnityEngine;

namespace Infrastructure.SoundManagement
{
    public class SoundService : MonoBehaviour
    {
        [SerializeField] private AudioSource _zombieSpawn;
        [SerializeField] private AudioSource _zombieDeath;
        [SerializeField] private AudioSource _heroDeath;
        [SerializeField] private AudioSource _heroShoot;
        [SerializeField] private AudioSource _background;
        [SerializeField] private AudioSource _move;
        [SerializeField] private AudioSource _collect;
        
        public void PlayZombieSpawn()
        {
            _zombieSpawn.Play();
        }
        
        public void PlayZombieDeath()
        {
            _zombieDeath.Play();
        }

        public void PlayHeroMove(bool value)
        {
            if(value)
                _move.Play();
            else
                _move.Stop();
        }
        
        public void PlayHeroDeath()
        {
            _heroDeath.Play();
        }
        
        public void PlayHeroCollect()
        {
            _collect.Play();
        }
        
        public void PlayShoot()
        {
            _heroShoot.Play();
        }
        
        public void PlayBackground()
        {
            _background.Play();
        }
    }
}