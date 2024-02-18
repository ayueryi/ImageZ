using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ImageZ.ShareControl.DrawingView;

[ObservableObject]
public partial class DrawingView : Canvas
{
    #region Class Members

    [ObservableProperty] private VisualCollection _graphicsList;

    public static readonly DependencyObject ToolProperty;

    public static readonly DependencyObject ActualScaleProperty;
    public static readonly DependencyObject IsDirtyProperty;

    public static readonly DependencyObject LineWidthProperty;
    public static readonly DependencyObject ObjectColorProperty;

    public static readonly DependencyObject TextFontFamilyNameProperty;
    public static readonly DependencyObject TextFontStyleProperty;
    public static readonly DependencyObject TextFontWeightProperty;
    public static readonly DependencyObject TextFontStretchProperty;
    public static readonly DependencyObject TextFontSizeProperty;

    public static readonly DependencyObject CanUndoProperty;
    public static readonly DependencyObject CanRedoProperty;

    public static readonly DependencyObject CanSelectAllProperty;
    public static readonly DependencyObject CanUnSelectAllProperty;
    public static readonly DependencyObject CanDeleteProperty;
    public static readonly DependencyObject CanDeleteAllProperty;
    public static readonly DependencyObject CanMoveToFrontProperty;
    public static readonly DependencyObject CanMoveToBackProperty;
    public static readonly DependencyObject CanSetPropertiesProperty;
    
    public static readonly DependencyObject CanCopyProperty;
    public static readonly DependencyObject CanPasteProperty;

    public static readonly RoutedEvent IsDirtyChangedEvent;

    #endregion
}