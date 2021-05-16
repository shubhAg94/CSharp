using System;
using System.Collections.Generic;
using System.Text;

namespace QuadrilateralsLSP
{
    //https://www.codeproject.com/Articles/595160/Understand-Liskov-Substitution-Principle-LSP
    //https://www.codeproject.com/Articles/595160/Understand-Liskov-Substitution-Principle-LSP
    public abstract class Quadrilaterals_LSP
    {
        abstract public int GetArea();
    }

    public class Rectangle_LSP : Quadrilaterals_LSP
    {
        private int _height;
        private int _width;
        public Rectangle_LSP(int height, int width)
        {
            _height = height;
            _width = width;
        }

        public override int GetArea()
        {
            return _height * _width;
        }
    }

    public class Square_LSP : Quadrilaterals_LSP  
    {
        public int _size;
        public Square_LSP(int size)
        {
            _size = size;
        }
        
        public override int GetArea()
        {
            return _size * _size;
        }
    }
}
