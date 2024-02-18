using System.Drawing;
using CommunityToolkit.Mvvm.ComponentModel;
using ImageZ.ShareControl.DrawingView.Graphics;
using Color = System.Windows.Media.Color;

namespace ImageZ.ShareControl.DrawingView.PropertiesGraphics;

[Serializable]
public partial class PropertiesGraphicsArrow : PropertiesGraphicsBase
{
    public PropertiesGraphicsArrow()
    {
        
    }

    #region Properties

    [ObservableProperty] private Point _end;
    [ObservableProperty] private Point _start;

    [ObservableProperty] private double _lineWidth;
    [ObservableProperty] private Color _objectColor;

    #endregion

    public override GraphicsBase CreateGraphics()
    {
        return base.CreateGraphics();
    }

    public override void UpdatePropertiesGraphics(GraphicsBase graphicsBase)
    {
        base.UpdatePropertiesGraphics(graphicsBase);
    }
}