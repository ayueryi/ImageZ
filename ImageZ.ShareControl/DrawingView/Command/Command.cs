namespace ImageZ.ShareControl.DrawingView.Command;

/// <summary>
/// Base class for cammands used for Undo - Redo
/// </summary>
public abstract class CommandBase
{
    public abstract void Undo();

    public abstract void Redu();
}