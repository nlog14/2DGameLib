﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameLib.Interfaces;

namespace _2DGameLib
{
    public class Creature : Position, ICreature
    {
        public int Hitpoints { get; set; }
        public string Name { get; set; }
        public CreatureStateEnum CurrentStateEnum { get; set; }
        public List<CreatureStateEnum> CreatureStates { get; set; }
        public WorldObjectsEnum CurrentWorldObject { get; set; }
        public Dictionary<WorldObjectsEnum, IWorldObjects> creatureStateWithWorldObj { get; }

        public Creature(CreatureStateEnum initialStateEnum = CreatureStateEnum.idle, WorldObjectsEnum initialStateWorldObject = WorldObjectsEnum.emptyHanded)
        {
            CurrentStateEnum = initialStateEnum;
            CreatureStates = new List<CreatureStateEnum>();
            CurrentWorldObject = initialStateWorldObject;
            creatureStateWithWorldObj = new Dictionary<WorldObjectsEnum, IWorldObjects>();
        }

        public List<AttackItem> attackItems = new List<AttackItem>();
        public List<DefenseItem> defenceItems = new List<DefenseItem>();

        public void SetCreaturesStateAttacking(WorldObjectsEnum state, IWorldObjects behavior )
        {
            creatureStateWithWorldObj[state] = behavior;
        }

        public void ActBehavior()
        {
            if (creatureStateWithWorldObj.ContainsKey(CurrentWorldObject))
            {
                creatureStateWithWorldObj[CurrentWorldObject].ChangeCreatureState();
            }
            else
            {
                throw new Exception($"No behavior defined for state {CurrentWorldObject}");
            }
        }

        /// <summary>
        /// Calculates the points a creature gains when attacking their enemy.
        /// </summary>
        /// <param name="enemy"></param>
        public void Attack(Creature enemy)
        {
            var attacks = attackItems.Sum(AttackItem => AttackItem.Hitpoint);
            enemy.ReceiveHits(attacks);
        }

        /// <summary>
        /// Check if world object is removable.
        /// If it is, it allows a creature to keep it, and adds it to the corresponding list.
        /// </summary>
        /// <param name="worldObject"></param>
        public void Loot(WorldObject worldObject)
        {
            if (worldObject.Removable)
            {
                if (worldObject is AttackItem)
                {
                    attackItems.Add(worldObject as AttackItem);
                }
                else if (worldObject is DefenseItem)
                {
                    defenceItems.Add(worldObject as DefenseItem);
                }
            }
        }

        /// <summary>
        /// Calculates the points a creature loses when they get hit by their enemy.
        /// </summary>
        /// <param name="hit"></param>
        public void ReceiveHits(int hit)
        {
            var defence = defenceItems.Sum(DefenceItem => DefenceItem.ReduceHitpoint);
            Hitpoints -= (hit - defence);
        }

        /// <summary>
        /// Checks if a creature is dead when their life points is equals to or less than 0.
        /// </summary>
        /// <returns></returns>
        public bool IsDead()
        {
            return Hitpoints is <= 0;
        }
    }
}
