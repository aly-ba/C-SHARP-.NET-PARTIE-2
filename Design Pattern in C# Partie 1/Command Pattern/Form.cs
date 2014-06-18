using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Command_Pattern
{
    class Form
    {
        private ShapeEnum _activeShape = ShapeEnum.Square;
        private Color _activeColor = Color.Blue;
        private Bitmap _bitmap;
        private Graphics _graphics;


        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
                // Each mouse down creates a new command class instance
                ICommand command = null;
                if (_activeShape == ShapeEnum.Square)
                command = new SquareCommand(_bitmap, _activeColor, e.X, e.Y);
                else if (_activeShape == ShapeEnum.Rectangle)
                    command = new RectangleCommand(_bitmap, _activeColor, e.X, e.Y);
                    command.Do();
                    _commandStack.Push(command);
                    RefreshUI();
                    
                private Stack<ICommand> _commandStack = new Stack<ICommand>();
                
         }
         private Stack<ICommand> _commandStack = new Stack<ICommand>();
        }
}
