﻿using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _height = 1.0;
        public double Height { get; set; }
       
        public Cylinder()
        {
            Center = new Point();
        }

        public Cylinder(double rad, double height)
        {
            Radius = rad;
            _height = height;
            Center = new Point();
        }

        public Cylinder(double x,double y,double rad,double height)
        {
            Center = new Point(x,y);
            Radius = rad;
            _height = Height;
        }

        public Cylinder(Circle cir)
        {
            Center = new Point(cir.Center);
            Raduis = cir.Radius;
        }

        public Cylinder(Cylinder a)
        {
            Center = new Point(a.Center);
            _height = a.Height;
            Radius = a.Radius;
        }

        public double getVolume()
        {
            return getArea() * _height;
        }

        public double getSurface()
        {
            return 2 * getArea() + Math.PI * Radius * 2 * _height;
        }

        override public string ToString()
        {
            return "[Cylinder: center(" + Center.X + ", " + Center.Y + "), radius=" + Radius + ", height=" + _height + ", surface=" + getSurface() + ", volume=" + getVolume() + "]";
        }
            }
}

