using UnityEngine;
using FrostfallSaga.Fight.Effects;


namespace FrostfallSaga.Fight.Abilities
{
    /// <summary>
    /// Abilities common fields.
    /// </summary>
    public abstract class BaseAbilityScriptableObject : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public string Description { get; private set; }
        [field: SerializeField] public Sprite IconSprite { get; private set; }
        [field: SerializeField] public AEffectScriptableObject[] Effects { get; private set; }
    }
}