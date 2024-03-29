﻿using PixelCrew.Creatures.HeroAll;
using UnityEngine;
using PixelCrew.Model;
using PixelCrew.Model.Definitions;
using PixelCrew.Model.Definitions.Localization;
using PixelCrew.Model.Definitions.Player;
using PixelCrew.UI.Widgets;
using PixelCrew.Utils;

namespace PixelCrew.UI.Hud
{
    public class HudController : MonoBehaviour
    {
        [SerializeField] private ProgressBarWidget _healthBar;
        [SerializeField] private ProgressBarWidget _oilBar;

        private GameSession _session;
        private void Start()
        {
            _session = GameSession.Instance;
            _session.Data.Hp.OnChanged += OnHealthChanged;
            _session.Data.Oil.OnChanged += OnOilChanged;

            OnHealthChanged(_session.Data.Hp.Value, 0);
        }

        private void OnHealthChanged(int newValue, int oldValue)
        {
            var maxHealth = _session.StatsModel.GetValue(StatId.Hp);
            var value = (float)newValue / maxHealth;
            _healthBar.SetProgress(value);
        }
        
        private void OnOilChanged(float newValue, float oldValue)
        {
            var maxOil = DefsFacade.I.Player.MaxOil;
            var value = (float)newValue / maxOil;
            _oilBar.SetProgress(value);
        }

        public void OnPause()
        {
            var hero = FindObjectOfType<Hero>();
            hero.IsPause = true;
            WindowUtils.CreateWindow("UI/InGameMenuWindow");
        }
        public void OnHelp()
        {
            var hero = FindObjectOfType<Hero>();
            hero.IsPause = true;
            switch (LocalizationManager.I.LocaleKey)
            {
                case "en":
                    WindowUtils.CreateWindow("UI/ManagementInputWindowEN");
                    break;
                case "ru":
                    WindowUtils.CreateWindow("UI/ManagementInputWindowRU");
                    break;
                default:
                    WindowUtils.CreateWindow("UI/ManagementInputWindowEN");
                    break;
            }
        }

        public void OnStatsWindow()
        {
            var hero = FindObjectOfType<Hero>();
            hero.IsPause = true;
            WindowUtils.CreateWindow("UI/PlayerStatsWindow");
        }
        private void OnDestroy()
        {
            _session.Data.Hp.OnChanged -= OnHealthChanged;
            _session.Data.Oil.OnChanged -= OnOilChanged;

        }

    }
}