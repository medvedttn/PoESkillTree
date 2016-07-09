﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using POESKillTree.Controls;
using POESKillTree.Model.Items;

namespace POESKillTree.Model
{
    public interface IPersistentData : INotifyPropertyChanged, INotifyPropertyChanging
    {
        Options Options { get; }
        PoEBuild CurrentBuild { get; set; }
        PoEBuild SelectedBuild { get; set; }
        BuildFolder RootBuild { get; }
        EquipmentData EquipmentData { get; }
        ObservableCollection<Item> StashItems { get; }
        ObservableCollection<StashBookmark> StashBookmarks { get; }
        IDictionary<string, IEnumerable<StashBookmark>> LeagueStashes { get; }

        /// <summary>
        /// Saves everything but the builds to the filesystem.
        /// </summary>
        void Save();

        /// <summary>
        /// Saves the given build to the filesystem.
        /// </summary>
        void SaveBuild(IBuild build);
    }
}