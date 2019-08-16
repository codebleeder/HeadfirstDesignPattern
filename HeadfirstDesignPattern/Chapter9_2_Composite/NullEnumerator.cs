using System.Collections;

namespace HeadfirstDesignPattern.Chapter9_2_Composite
{
    public class NullEnumerator: IEnumerator 
    {
        public NullEnumerator()
        {
        }

        public object Current => null;
        //public MenuComponent Current => null;
        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}