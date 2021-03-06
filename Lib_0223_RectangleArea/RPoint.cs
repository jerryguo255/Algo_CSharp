﻿using System;

namespace Lib_0223_RectangleArea
{
    public struct RPoint : IComparable<RPoint>, IEquatable<RPoint>
    {
        public int X { get; }
        public int Y { get; }

        public RPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X:{X} Y:{Y}";
        }


        /// <summary>
        /// rightTop to leftBottom , great to less,
        /// if one of both point's comparison = 0, then compare another,
        /// if both point's comparison not equal and not 0, then return 0
        /// </summary>
        /// <param name="other"></param>
        /// <returns>0 means same or invalid, -1 means this point lo</returns>
        public int CompareTo(RPoint other)
        {
            var xComparison = X.CompareTo(other.X);
            var yComparison = Y.CompareTo(other.Y);

            if (xComparison == 0)
            {
                return Y.CompareTo(other.Y);
            }
            if (yComparison == 0)
            {
                return X.CompareTo(other.X);
            }
            if (xComparison != yComparison)
            {
                return 0;
            }

            return xComparison;
        }

        /// <summary>
        /// LeftTop To RightBottom , great to less
        /// if one of both point's comparison = 0, then compare another,
        /// if both point's comparison not equal and not 0, then return 0
        /// </summary>
        /// <param name="other"></param>
        /// <param name="isLeftTopToRightBottom"></param>
        /// <returns></returns>
        public int CompareTo(RPoint other,bool isLeftTopToRightBottom)
        {
            var xComparison = X.CompareTo(other.X);
            var yComparison = Y.CompareTo(other.Y);
            if (!isLeftTopToRightBottom) return 0;
            if (xComparison == 0) return Y.CompareTo(other.Y);
            
            if (yComparison == 0) return X.CompareTo(other.X) * -1;
            
            if (xComparison == yComparison) return 0;

            if (xComparison > 0 && yComparison < 0) return -1;
            
            if (xComparison < 0 && yComparison > 0) return 1;
            
            return 0;
        }



        /// <summary>
        /// flag 0 : rightTop to leftBottom , great to less,
        /// flag 1:   LeftTop To RightBottom , great to less
        /// ###if there is one of both point's comparison = 0, then return zero###,
        /// </summary>
        /// <param name="other"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public int CompareTo(RPoint other, byte flag)
        {
            var xComparison = X.CompareTo(other.X);
            var yComparison = Y.CompareTo(other.Y);
            if (flag == 0)
            {
                if (xComparison == 0 || yComparison == 0)
                {
                    return 0;
                }
               
                if (xComparison != yComparison)
                {
                    return 0;
                }


                return xComparison;
            }

            if (flag ==1)
            {
                
                if (xComparison == 0 || yComparison == 0) return 0;

               

                if (xComparison == yComparison) return 0;

                if (xComparison > 0 && yComparison < 0) return -1;

                if (xComparison < 0 && yComparison > 0) return 1;

              
            }

            return 0;


        }

        public override bool Equals(object obj)
        {
            return obj is RPoint other && Equals(other);
        }


        public bool Equals(RPoint other)
        {
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }



        public static bool operator ==(RPoint lhs, RPoint rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(RPoint lhs, RPoint rhs)
        {
            return !lhs.Equals(rhs);
        }
    }
}