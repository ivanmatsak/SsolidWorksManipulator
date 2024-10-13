using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media.Media3D;
using System.Windows;

namespace CellsConstructor_v._1
{
    class Area2
    {
        public readonly Point[] points;
        public readonly Point center;

        public Area2(Point[] points)
        {
            this.points = points;

            center = GetCenterPoint(points);
        }

        private static Point GetCenterPoint(Point[] points) {
            double x = 0;
            double y = 0;

            for (int i = 0; i < points.Length; i++) {
                x += points[i].X;
                y += points[i].Y;
            }

            return new Point(x / points.Length, y / points.Length);
        }

        public PointInPolygon PointInArea(Point point) {

            //PointInPolygon result = PointInPolygon.OUTSIDE;

            //for (int i = 0; i < points.Length; i++)
            //{
            //    Point v = points[i];
            //    Point w = points[(i + 1) % points.Length];

            //    switch (edgeType(point, v, w))
            //    {
            //        case EdgeType.TOUCHING:
            //            result =  PointInPolygon.BOUNDARY;
            //            break;
            //        case EdgeType.CROSSING:
            //            result = PointInPolygon.INSIDE;
            //            break;
            //    }
            //}

            //return result;

            bool parity = true;
            for (int i = 0; i < points.Length; i++)
            {
                Point v = points[i];
                Point w = points[(i + 1) % points.Length];

                switch (edgeType(point ,v, w))
                {
                    case EdgeType.TOUCHING:
                        return PointInPolygon.BOUNDARY;
                    case EdgeType.CROSSING:
                        parity = !parity;
                        break;
                }
            }

            return parity ? PointInPolygon.OUTSIDE : PointInPolygon.INSIDE;
        }

        // Тип ребра vw для точки a
        private EdgeType edgeType(Point a, Point v, Point w) 
        {
            switch (classify(a, v, w))
            {
                case PointOverEdge.LEFT:
                    return ((v.Y < a.Y) && (a.Y <= w.Y)) ? EdgeType.CROSSING : EdgeType.INESSENTIAL;
                case PointOverEdge.RIGHT:
                    return ((w.Y < a.Y) && (a.Y <= v.Y)) ? EdgeType.CROSSING : EdgeType.INESSENTIAL;
                case PointOverEdge.BETWEEN:
                    return EdgeType.TOUCHING;
                default:
                    return EdgeType.INESSENTIAL;
            }
        }

        // Положение точки p относительно отрезка vw
        private PointOverEdge classify(Point p, Point v, Point w)
        {
            // точка лежит на прямой, но не на отрезке
            PointOverEdge result = PointOverEdge.OUTSIDE;

            // Коэффициенты уравнения прямой
            double a = v.Y - w.Y;
            double b = w.X - v.X;
            double c = v.X * w.Y - w.X * v.Y;

            // Подставим точку в уравнение прямой
            double f = a * p.X + b * p.Y + c;

            if (f > 0)
            {
                // Точка лежит справа от отрезка
                result = PointOverEdge.RIGHT;
            }
            else if (f < 0)
            {
                // Слева от отрезка
                result = PointOverEdge.LEFT;
            }
            else
            {

                double minX = Math.Min(v.X, w.X);
                double maxX = Math.Max(v.X, w.X);

                double minY = Math.Min(v.Y, w.Y);
                double maxY = Math.Max(v.Y, w.Y);

                if (
                    (minX <= p.X) &&
                    (p.X <= maxX) &&
                    (minY <= p.Y) &&
                    (p.Y <= maxY))
                {
                    // Точка лежит на отрезке
                    result = PointOverEdge.BETWEEN;
                }

            }

            return result;
        }

    }


    // Положение точки в многоугольнике
    public enum PointInPolygon 
    { 
        INSIDE, 
        OUTSIDE, 
        BOUNDARY 
    }

    // Положение ребра
    public enum EdgeType 
    { 
        TOUCHING,
        CROSSING, 
        INESSENTIAL 
    }

    // Положение точки относительно отрезка
    public enum PointOverEdge 
    { 
        LEFT, 
        RIGHT, 
        BETWEEN,
        OUTSIDE 
    } 

}