using System;
using Engine.Models;
using Engine.Actions;

namespace Engine.Actions
{
    public class AttackWithWeapon : IAction
    {
        private readonly GameItem _weapon;
        private readonly int _maximumDamage;
        private readonly int _minimumDamage;

        public event EventHandler<string> OnActionPerformed;

        public AttackWithWeapon(GameItem weapon, int minimumDamange, int maximumDamage)
        {
            if (weapon.Category != GameItem.ItemCategory.Weapon)
            {
                throw new ArgumentException($"{weapon.Name} is not a weapon!");
            }

            if (_minimumDamage < 0)
            {
                throw new ArgumentException("minimumDamage must be 0 or larger");
            }

            if (_maximumDamage < _minimumDamage)
            {
                throw new ArgumentException("maximumDamage must be >= minimumDamage");
            }

            _weapon = weapon;
            _minimumDamage = minimumDamange;
            _maximumDamage = maximumDamage;
        }

        public void Execute(LivingEntity actor, LivingEntity target)
        {
            // Calculate RNG damage to target
            int damage = RandomNumberGenerator.NumberBetween(_minimumDamage, _maximumDamage);

            string actorName = (actor is Player) ? "You" : $"The {actor.Name.ToLower()}";
            string targetName = (target is Player) ? "you" : $"the {target.Name.ToLower()}";

            if (damage == 0)
            {
                ReportResult($"{actorName} missed {targetName}.");
            }
            else
            {
                ReportResult($"{actorName} hit {targetName} for {damage} damage.");

                target.TakeDamage(damage);
            }
        }

        private void ReportResult(string result)
        {
            OnActionPerformed?.Invoke(this, result);
        }
    }
}