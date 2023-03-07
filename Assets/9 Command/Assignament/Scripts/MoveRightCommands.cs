using UnityEngine;

namespace Command.Assignament.Scripts
{
    public class MoveRightCommands : MonoBehaviour, ICommands
    {
        public void Execute()
        {
            var transformPosition = gameObject.transform.position;
            transformPosition.x           += 1;
            gameObject.transform.position =  transformPosition;
        }

        public void Undo()
        {
            var transformPosition = gameObject.transform.position;
            transformPosition.x           -= 1;
            gameObject.transform.position =  transformPosition;
        }
    }
}