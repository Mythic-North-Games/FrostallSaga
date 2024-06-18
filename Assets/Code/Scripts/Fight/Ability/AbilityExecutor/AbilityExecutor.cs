using FrostfallSaga.Fight.Fighters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrostfallSaga.Fight.Abilities.AbilityExecutor
{

    public class AbilityExecutor
    {
        public Action<Fighter> OnFighterTouched()
        {
            return null;
        }

        public void Execute(AbilityExecutionConfiguration configuration, Cell[] cells)
        {

        }
    }
}