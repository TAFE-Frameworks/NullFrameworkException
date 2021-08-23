using UnityEngine;

namespace NullFrameworkException.Test.Core
{
    public class CoreTesting : MonoBehaviour
    {
        public Transform cube;
        
        private Optional<RunnableTest> runnableTest = Optional<RunnableTest>.Empty();
        
        // Start is called before the first frame update
        private void Start()
        {
            RunnableUtils.Setup(ref runnableTest, gameObject, cube, 1f, Vector3.up);
        }

        // Update is called once per frame
        private void Update()
        {
            RunnableUtils.Run(ref runnableTest, gameObject, Input.GetKey(KeyCode.Space));

            if(Input.GetKeyDown(KeyCode.A))
            {
                runnableTest.Get().Enabled = !runnableTest.Get().Enabled;
            }
        }
    }
}