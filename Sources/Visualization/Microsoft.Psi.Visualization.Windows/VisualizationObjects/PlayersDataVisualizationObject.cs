// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

#pragma warning disable

namespace Microsoft.Psi.Visualization.VisualizationObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Numerics;
    using System.Runtime.Serialization;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.Psi.Visualization.Data;
    using Microsoft.Psi.Visualization.Helpers;
    using Microsoft.Psi.Visualization.Summarizers;
    using Microsoft.Psi.Visualization.Views.Visuals2D;
    using Microsoft.Psi.Visualization.VisualizationPanels;

    /// <summary>
    /// Implements a visualization object for PlayersData.
    /// </summary>
    [VisualizationObject("PlayersData")]
    [VisualizationPanelType(VisualizationPanelType.Canvas)]
    public class PlayersDataVisualizationObject : StreamValueVisualizationObject<List<PlayersData>>, INotifyPropertyChanged
    {
        /// <inheritdoc/>
        [IgnoreDataMember]
        public override DataTemplate DefaultViewTemplate => XamlHelper.CreateTemplate(this.GetType(), typeof(PlayersDataVisualizationObjectView));

        // On update
        protected override void OnPropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            base.OnPropertyChanging(sender, e);

            if (e.PropertyName == nameof(this.CurrentValue))
            {
                this.RaisePropertyChanging(nameof(this.Players));
            }
        }

        protected override void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(this.CurrentValue))
            {
                this.RaisePropertyChanged(nameof(this.Players));
            }

            base.OnPropertyChanged(sender, e);
        }

        public List<PlayersData> Players
        {
            get 
            {
                return this.CurrentValue.HasValue ? this.CurrentValue.Value.Data : new List<PlayersData>();
            }
        }
    }
}