using System.Drawing;
using System.Windows.Media;
using System.Windows.Shapes;
using Color = System.Windows.Media.Color;

namespace ImageZ.ShareControl.DrawingView.Graphics;

public abstract class GraphicsBase : DrawingVisual
{
    #region Constructor

    protected GraphicsBase() => Id = GetHashCode();

    public GraphicsBase Clone() => MemberwiseClone() as GraphicsBase;
    
    #endregion

    #region Class Members

    protected double graphicsLineWith;
    
    protected Color graphicsObjectColor;

    protected double graphicsActualScale;

    protected bool isSelectd;

    protected const double HitTestWidth = 8.0;

    private double handleSize = 10.0;
    
    private static SolidColorBrush handleBrush1 = new(Color.FromArgb(100, 0, 0, 0));

    private static readonly SolidColorBrush handleBrush2 = new(Color.FromArgb(100, 255, 255, 255));

    private static readonly SolidColorBrush handleBrush3 = new(Color.FromArgb(0, 255, 255, 255));

    #endregion

    #region Properties

    public int Id { get; set; }

    public bool IsSelected
    {
        get => isSelectd;
        set
        {
            isSelectd = value;
            //RefreshDrawing();
        }
    }
    
    public double LineWidth
    {
        get => graphicsLineWith;
        set
        {
            graphicsLineWith = value;
            //RefreshDrawing();
        }
    }
    
    public Color ObjectColor
    {
        get => graphicsObjectColor;
        set
        {
            graphicsObjectColor = value;
            //RefreshDrawing();
        }
    }
    
    public double ActualScale
    {
        get => graphicsActualScale;
        set
        {
            graphicsActualScale = value;
            //RefreshDrawing();
        }
    }

    protected double ActualLineWidth
        => ActualScale <= 0 ? LineWidth : LineWidth / ActualScale;

    protected double LineHitTestWidth
        => Math.Max(8.0, ActualLineWidth);
    
    public double HandleSize
    {
        get => handleSize / (1 + 2 * Math.Exp(-LineWidth));
        set => handleSize = value; 
    }

    #endregion

    #region Abstract Methods and Properties

    public abstract int HandleCount { get; }

    public abstract bool Contains(Point point);
    
    //public abstract 

    #endregion
}