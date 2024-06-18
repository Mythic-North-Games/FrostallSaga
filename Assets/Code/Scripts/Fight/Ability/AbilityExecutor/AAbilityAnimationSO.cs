using FrostfallSaga.Fight.Fighters;
using System;

namespace FrostfallSaga.Fight.Abilities.AbilityExecutor
{
    public class AAbilityAnimationSO
    {
        public Action<Fighter> OnFighterTouched { get; set; }
        public AAbilityAnimationExecutor Executor {  get; set; }
    }
}