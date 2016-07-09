using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class UndoRedo
{
    public List<Shape> lstShape = new List<Shape>();

    public void AddShape(Shape shape)
    {
        lstShape.Add(shape);
    }

    public void Undo()
    {
        lstShape.RemoveAt(lstShape.Count - 1);
    }
}

