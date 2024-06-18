using FrostfallSaga.Fight.Effects;
using FrostfallSaga.Fight.Targeters;
using UnityEngine;

namespace FrostfallSaga.Fight.Fighters
{
    [CreateAssetMenu(fileName = "Fighter", menuName = "ScriptableObjects/Fight/Fighter", order = 0)]
    public class FighterConfigurationSO : ScriptableObject
    {
        [field: SerializeField] public ActiveAbilitiesToAnimation[] AvailableActiveAbilities { get; private set; }
        [field: SerializeField] public TargeterSO DirectAttackTargeter { get; private set; }
        [field: SerializeField] public AEffectSO[] DirectAttackEffects { get; private set; }

        #region Base stats
        [field: SerializeField, Range(1, 9999)] public int MaxHealth { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int MaxActionPoints { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int MaxMovePoints { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int Strength { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int Dexterity { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int MagicalStrength { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int PhysicalResistance { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int FireResistance { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int WaterResistance { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int IceResistance { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int WindResistance { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int LightningResistance { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int EarthResistance { get; private set; }
        [field: SerializeField, Range(1, 9999)] public int Initiative { get; private set; }
        #endregion
    }
}