using System;
using System.Collections.Generic;
using System.Text;

namespace QuadrilateralsLSP
{
    //https://www.dotnetcurry.com/software-gardening/1235/liskov-substitution-principle-lsp-solid-patterns
    public class Rectangle
    {
        protected int _width;
        protected int _height;

        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public virtual void SetWidth(int width)
        {
            _width = width;
        }

        public virtual void SetHeight(int height)
        {
            _height = height;
        }

        public int Area
        {
            get { return _height * _width; }
        }
    }

    public class Square : Rectangle
    {
        public override void SetWidth(int width)
        {
            _width = width;
            _height = width;
        }

        public override void SetHeight(int height)
        {
            _width = height;
            _height = height;
        }
    }
}
