using UnityEngine;

namespace Command.Assignament.Scripts
{
    public class MoveRightCommands : MonoBehaviour, ICommands
    {
        public void Execute()
        {
            var position = gameObject.transform.position;
            position                      = new Vector3(position.x+1,position.y,position.z);
            gameObject.transform.position = position;
            CommandManager.ExecuteCommand(this);
        }

        public void Undo()
        {
            var position = gameObject.transform.position;
            position                      = new Vector3(position.x-1,position.y,position.z);
            gameObject.transform.position = position;
        }
    }
}