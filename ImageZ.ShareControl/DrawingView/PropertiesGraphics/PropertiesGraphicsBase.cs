using CommunityToolkit.Mvvm.ComponentModel;
using ImageZ.ShareControl.DrawingView.Graphics;

namespace ImageZ.ShareControl.DrawingView.PropertiesGraphics;

[Serializable]
public partial class PropertiesGraphicsBase : ObservableObject
{
    [ObservableProperty] internal int _id;
    
    [ObservableProperty] private List<PropertiesGraphicsBase> _channelsBase = new();

    [ObservableProperty] private string _imgName;
    
    [ObservableProperty] private string _imgPath;

    [ObservableProperty] private bool _isSelected;
    
    public virtual GraphicsBase CreateGraphics() =>  null;

    public virtual void UpdatePropertiesGraphics(GraphicsBase graphicsBase)
    {
        
    }
}