using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using вдишп1.Models;

namespace вдишп1.Iterator
{
    class TrainEnumerator : IEnumerator
    {
        Train[] collection;
        int position = -1;
        public TrainEnumerator(Train[] collection)
        {
            this.collection = collection;
        }
        public object Current
        {
            get
            {
                if (position == -1 || position >= collection.Length)
                    throw new InvalidOperationException();
                return collection[position];
            }
        }

        public bool MoveNext()
        {
            if (position < collection.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
    public class TrainsCollection
    {
        Train[] collection;

        public TrainsCollection()
        {

        }

        public TrainsCollection(Train[] trains)
        {
            collection = trains;
        }

        public IEnumerator GetEnumerator()
        {
            return new TrainEnumerator(collection);
        }
    }


}
