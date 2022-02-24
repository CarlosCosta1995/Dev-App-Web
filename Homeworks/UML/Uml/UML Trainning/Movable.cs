using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Trainning
{
    public interface IMovable
    {
        public void moveUp();
        public void moveDown();
        public void moveLeft();
        public void moveRight();
    }

    public class MovablePoint : IMovable
    {
        public void moveDown()
        {
            throw new NotImplementedException();
        }

        public void moveLeft()
        {
            throw new NotImplementedException();
        }

        public void moveRight()
        {
            throw new NotImplementedException();
        }

        public void moveUp()
        {
            throw new NotImplementedException();
        }
    }
}
