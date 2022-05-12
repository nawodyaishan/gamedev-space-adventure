using UnityEngine;

namespace Player_Scripts
{
    public class EngineFires : MonoBehaviour
    {
        // To Attach All the Particles in Player Ship
        [SerializeField] private ParticleSystem[] engineFires;

        // Engine Power
        [SerializeField] private int enginePower = 10;

        private void Update()
        {
            HandleFireEngine();
        }

        private void HandleFireEngine()
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                EmiEngineFireParticle(2, enginePower);
                EmiEngineFireParticle(3, enginePower);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                EmiEngineFireParticle(4, enginePower);
                EmiEngineFireParticle(5, enginePower);
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                EmiEngineFireParticle(0, enginePower);
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                EmiEngineFireParticle(1, enginePower);
            }
        }

        void EmiEngineFireParticle(int engineIndex, int enginePower)
        {
            engineFires[engineIndex].Emit(enginePower);
        }
    }
} // Class