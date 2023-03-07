using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Command
{
public class CommandInvoker
{
    // stack of command objects to undo
    private static Stack<ICommand> _undoStack = new Stack<ICommand>();

    // second stack of redoable commands
    private static Stack<ICommand> _redoStack = new Stack<ICommand>();

    public static Stack<ICommand> RedoStack => _redoStack;

    // execute a command object directly and save to the undo stack
    public static void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _undoStack.Push(command);

        // clear out the redo stack if we make a new move
        RedoStack.Clear();

    }

    public static void UndoCommand()
    {
        if (_undoStack.Count > 0)
        {
            ICommand activeCommand = _undoStack.Pop();
            RedoStack.Push(activeCommand);
            activeCommand.Undo();
        }
    }

    public static void RedoCommand()
    {
        if (RedoStack.Count > 0)
        {
            ICommand activeCommand = RedoStack.Pop();
            _undoStack.Push(activeCommand);
            activeCommand.Execute();
        }
    }
}
}