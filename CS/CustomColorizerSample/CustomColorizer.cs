#region #CustomColorizerImplementation
using DevExpress.TreeMap;
using DevExpress.XtraTreeMap;
using System;
using System.Drawing;

namespace CustomColorizerSample {
    class CustomColorizer : ITreeMapColorizer {
        Palette palette = Palette.Office2016Palette;

        public Palette Palette {
            get { return palette; }
            set {
                if(palette.Equals(value)) return;
                palette = value;
                RaiseColorizerChanged();
            }
        }

        public event ColorizerChangedEventHandler ColorizerChanged;

        public Color GetItemColor(ITreeMapItem item, TreeMapItemGroupInfo group) {
            if(item.Children.Count == 0) {
                Color itemColor = Palette[group.ItemIndex % Palette.Count];
                double itemWeight = (item.Value - group.MinValue) / (group.MaxValue - group.MinValue);
                if(Double.IsNaN(itemWeight)) itemWeight = 1;

                return Color.FromArgb(
                    (int)(itemWeight * 255),
                    itemColor.R,
                    itemColor.G,
                    itemColor.B
                );
            }
            else
                return Palette[Palette.Count - 1 - (group.GroupIndex + group.GroupLevel + group.ItemIndex) % Palette.Count];

        }

        void RaiseColorizerChanged() {
            if(ColorizerChanged == null) return;
            ColorizerChanged.Invoke(this, new ColorizerChangedEventArgs());
        }
    }
}
#endregion #CustomColorizerImplementation