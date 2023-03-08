using UnityEngine;

namespace Command.Assignament.Scripts
{
    public class MoveUpCommands : MonoBehaviour, ICommands
    {
        public void Execute()
        {
            var position = gameObject.transform.position;
            position                      = new Vector3(position.x,position.y + 1,position.z);
            gameObject.transform.position = position;
            CommandManager.ExecuteCommand(this);
        }

        public void Undo()
        {
            var position = gameObject.transform.position;
            position                      = new Vector3(position.x,position.y - 1,position.z);
            gameObject.transform.position = position;
        }
    }
}