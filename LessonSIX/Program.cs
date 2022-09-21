﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonSIX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManyFigure mf = new ManyFigure(3);
            mf.DrawFigureSide();
            Console.ReadLine();
        }
    }
    abstract class GeometryFigure
    {
        protected int FigureSquare;
       protected  int FigurePerimeter;
    }
    class Triangle : GeometryFigure
    {
        public int Base { get; set; }
       public  int BaseSideAngle { get; set; }
       public  int SideLeight { get; set; }
       public  int Area { get { return FigureSquare; } set{FigureSquare=value; } }
       public  int Perimeter { get { return FigurePerimeter; } set {FigurePerimeter=value; } }
    }
    class Quadro : GeometryFigure
    {
      
        public int Base { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePerimeter; } set { FigurePerimeter = value; } }
    }
    class Romb : GeometryFigure
    {
       
        public int Base { get; set; }
        public int BaseSideAngle { get; set; }
        public int SideLeight { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePerimeter; } set { FigurePerimeter = value; } }
    }
    class Rectangle : GeometryFigure
    {
        
        public int Base { get; set; }
        public int BaseSideAngle { get; set; }
        public int SideLeight { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePerimeter; } set { FigurePerimeter = value; } }
    }
    class ParalleloGram : GeometryFigure
    {


    public int Height { get; set; }
        public int Base { get; set; }
        public int BaseSideAngle { get; set; }
       
     
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePerimeter; } set { FigurePerimeter = value; } }
    }
    class Trapecia : GeometryFigure
    {
        public int Height { get; set; }
        public int Base { get; set; }
        public int BaseSideAngle { get; set; }
        
        public int SideLeight { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePerimeter; } set { FigurePerimeter = value; } }
    }
    class Circle : GeometryFigure
    {
        public int Radius { get; set; }
       
        
       
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePerimeter; } set { FigurePerimeter = value; } }
    }
    class Ellipse : GeometryFigure
    {
        public int Height { get; set; }
        public int Base { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimeter { get { return FigurePerimeter; } set { FigurePerimeter = value; } }
    }
    interface ISimpleNAngle
    {
        int Height { get; set; }
        int Base { get; set; }
        int BaseSideAngle { get; set; }
        int NumberSide { get; set; }
        int SideLeight { get; set; }
        int Area { get; set; }
        int Perimeter { get; set; }

    }
    class ManyFigure:ISimpleNAngle
    {
        char[] drawChars = new char[11];
        public int Height { get; set; }
       public int Base { get; set; }
      public   int BaseSideAngle { get; set; }
       public int NumberSide { get; set; }
       public int SideLeight { get; set; }
       public int Area { get; set; }
        public int Perimeter { get; set; }
        public ManyFigure(int numberSide)
        {
            NumberSide = numberSide;
            BaseSideAngle = 360 / NumberSide;
        }

        public void DrawFigureSide()
        {
            double angle = 360 / NumberSide;
           
            for (int i = 1; i <= drawChars.Length; i += 2)
            {
                int temp = (int)Math.Floor((double)(drawChars.Length / 2) - (int)Math.Floor((double)i / 2));
                for (int j = 0; j <i; j++)
                {
                    drawChars[temp+j] = '*';
                }
                Console.WriteLine(drawChars);
            }
        }
        double FindArea()
        {
            return Area;
        }
}
}
