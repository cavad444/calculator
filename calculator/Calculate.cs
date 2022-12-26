using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Calculator : IOperation
    {
        private double _x;
        private double _y;
        private string _operator;
        double netice = 0;


        public double X { get { return _x; } set { _x = value; } } 
        public double Y { get { return _y; } set { _y = value; } } 
        public string Operator { 
            get {
                return _operator; 
            } 
            set {
                try
                {
                    _operator = value;

                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
            } }
        public void Calculate()
        {
            
            if(_operator == "+")
            {
                netice = _x + _y;
            }else if (_operator == "*")
            {
                netice = _x * _y;
            }else if(_operator == "/")
            {
                netice = _x / _y;
            }else if (_operator == "-")
            {
                netice = _x - _y;
            }
            else
            {
                Console.WriteLine("Zehmet olmasa bu riyaziyyat emellerinden birini sechin:-,+,/,*");
            }
            Console.WriteLine(netice);

           
            
        }
        
    }
}
