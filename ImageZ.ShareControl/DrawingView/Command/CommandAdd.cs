using ImageZ.ShareControl.DrawingView.Graphics;
using ImageZ.ShareControl.DrawingView.PropertiesGraphics;

namespace ImageZ.ShareControl.DrawingView.Command;

public class CommandAdd : CommandBase
{
    private readonly PropertiesGraphicsBase newObjectClone;

    public CommandAdd(GraphicsBase newObject)
    {
        //newObjectClone = newObject.Create
    }

    public override void Undo()
    {
        throw new NotImplementedException();
    }

    public override void Redo()
    {
        throw new NotImplementedException();
    }
}