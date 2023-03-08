using System.Collections.Generic;

namespace Command.Assignament.Scripts
{
    public class CommandManager
    {
        private static Stack<ICommands> undoCommands = new Stack<ICommands>();

        public static void ExecuteCommand(ICommands commands)
        {
            undoCommands.Push(commands);
        }

        public static void UndoCommand()
        {
            if (undoCommands.Count > 0)
            {
                ICommands currentCommands = undoCommands.Pop();
                currentCommands.Undo();
            }
        }

    }
}