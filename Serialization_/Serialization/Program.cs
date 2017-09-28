using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{ 
    class Program
    {
        static void Main(string[] args)
        {
            List<Complex> x = new List<Complex>();
            x.Add(new Complex (4,9));
           
           // Serialization(x);
            Deserialization();
            Console.ReadKey();
        }
        static void Serialization(List<Complex> x)
        {
            
            BinaryFormatter s = new BinaryFormatter();
            FileStream bin = new FileStream(@"binPixels.data", FileMode.Create);
            s.Serialize(bin, x);
            bin.Close();
        }
        static void Deserialization()
        {
            BinaryFormatter ds = new BinaryFormatter();
            FileStream text = new FileStream(@"binPixels.data", FileMode.Open);
            List<Complex> binData = (List<Complex>)ds.Deserialize(text);
            text.Close();   
            foreach(Complex i in binData)
            {
                Console.WriteLine("x={0}, y={1}", i.a, i.b);
            }
        }
       
           

            

}

    [Serializable]
    class Complex: ISerializable
    {
        public int a;
        public int b;
        public Complex() { }
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("A", a);
            info.AddValue("B", b);
        }
        public Complex(SerializationInfo info, StreamingContext context)
        {
            a = (int)info.GetValue("A", typeof(int));
            b= (int)info.GetValue("B", typeof(int));
        }
       
    }
    

}
