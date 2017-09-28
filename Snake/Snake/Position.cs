using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]
    class Position : ISerializable
    {
        public int a;
        public int b;
        public Position() { }
        public Position(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("A", a);
            info.AddValue("B", b);
        }
        public Position(SerializationInfo info, StreamingContext context)
        {
            a = (int)info.GetValue("A", typeof(int));
            b = (int)info.GetValue("B", typeof(int));
        }

    }
}
