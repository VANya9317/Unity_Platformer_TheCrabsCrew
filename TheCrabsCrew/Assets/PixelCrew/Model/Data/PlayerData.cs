﻿using System;
using UnityEngine;
using PixelCrew.Model.Data.Properties;
namespace PixelCrew.Model.Data
{
    [Serializable]
    public class PlayerData
    {
        [SerializeField] private InventoryData _inventory;
        [Space]
        [Space]
        public IntProperty Hp = new IntProperty();
        public FloatProperty Oil = new FloatProperty();
        public PerksData Perks = new PerksData();
        public LevelData Levels = new LevelData();
        public InventoryData Inventory => _inventory;
        public PlayerData Clone()
        {
            var json = JsonUtility.ToJson(this);
            return JsonUtility.FromJson<PlayerData>(json);
        }
    }
}