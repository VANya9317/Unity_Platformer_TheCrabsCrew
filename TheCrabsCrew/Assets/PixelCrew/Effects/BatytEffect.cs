using PixelCrew.Creatures.HeroAll;
using UnityEngine;

namespace PixelCrew.Effects
{
    public class BatytEffect : MonoBehaviour
    {
        [SerializeField] private float _batytJumpSpeed;
        private Hero Hero;
        
        private void Start()
        {
            Hero = FindObjectOfType<Hero>();
        }
        
        public void Batyt()
        {
            Hero.Batyt(_batytJumpSpeed);
        }
    }
}