using System;
using System.Collections;
using System.Linq;

namespace IteratorPattern
{
    //We make _objects to private, The reason with this implementation is that the List class should not expose its internal structure 
    //(object[]) for storing data.
    //Otherwise this violates the information hiding principle of object-oriented programming.
    //It gives the outside world intimate knowledge of the design of this class.

    //If tomorrow we decide to replace the array with a binary search tree, 
    //all the code that directly reference the Object array need to modified.
    //So, MyList should not expose their internal structure.This means we make the Objects array private.

    //So, with this change, we’re hiding the internal structure of this class from the outside. 
    //But this leads to a new different problem: how are we going to iterate over this list? 
    //We no longer have access to the Objects array, and we cannot use it in a loop.

    //That’s when the iterator pattern comes into the picture. 
    //It provides a mechanism to traverse an object irrespective of how it is internally represented.

    class MyList : IEnumerable
    {
        private object[] _objects;

        private int arrayIndex = 0;
        public MyList()
        {
            _objects = new object[100];
        }

        public void Add(object obj)
        {
            _objects[arrayIndex] = obj;
            arrayIndex++;
        }

        public object this[int index]
        {
            get { return _objects[index]; }
        }

        //So I added the IEnumerable interface at the declaration of the class and also created the GetEnumerator method. 
        //This method should return an instance of a class that implements IEnumerator

        //Note that with this interface, the client of our class no longer knows about its internal structure. 
        //It doesn’t know if we have an array or a binary search tree or some other data structure in the List class. 
        //It simply calls GetEnumerator, receives an enumerator and uses that to enumerate the List. 
        //If we change the internal structure, this client code will not be affected whatsoever.

        //So, the iterator pattern provides a mechanism to iterate a class without being coupled to its internal structure.

        // This method should return an instance of a class that implements IEnumerator. So, we’re going to create a new class called ListEnumerator.
        public IEnumerator GetEnumerator()
        {
            return new MyListEnumerator(_objects);
        }


        //You might ask: “Mosh, why are you declaring ListEnumerator as a nested private class? Aren’t nested classes ugly?” 
        //The ListEnumerator class is part of the implementation of our List class. As you’ll see shortly, 
        //It’ll have intimate knowledge of the internal structure of the List class. 
        //If tomorrow I replace the array with a binary search tree, I need to modify ListEnumerator to support this. 
        //I don’t want anywhere else in the code to have a reference to the ListEnumerator; 
        //otherwise, the internals of the List class will be leaked to the outside again.

        internal class MyListEnumerator : IEnumerator
        {
            private int _currentIndex = -1;

            private object[] _objects;

            internal MyListEnumerator(object[] _objects)
            {
                this._objects = _objects;
            }

            public object Current
            {
                get
                {
                    try
                    {
                        return _objects[_currentIndex];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            public bool MoveNext()
            {
                _currentIndex++;
                return (_currentIndex < _objects.Count());
            }

            public void Reset()
            {
                _currentIndex = -1;
            }
        }
    }
}
