﻿using Bridge;

namespace System
{
    [Ignore]
    [Name("Math")]
    public static class Math
    {
        public const double E = 0;
        public const double LN10 = 0;
        public const double LN2 = 0;
        public const double LOG2E = 0;
        public const double LOG10E = 0;
        public const double PI = 0;
        public const double SQRT1_2 = 0;
        public const double SQRT2 = 0;

        public static int Abs(int x)
        {
            return 0;
        }

        public static double Abs(double x)
        {
            return 0;
        }

        public static double Abs(long x)
        {
            return 0;
        }

        [Template("{l}.abs()")]
        public static extern decimal Abs(decimal l);

        public static int Max(params int[] values)
        {
            return 0;
        }

        public static double Max(params double[] values)
        {
            return 0;
        }

        public static double Max(params long[] values)
        {
            return 0;
        }

        public static double Max(params ulong[] values)
        {
            return 0;
        }

        [Template("Bridge.Decimal.max({*values})")]
        public static extern decimal Max(params decimal[] values);

        public static int Min(params int[] values)
        {
            return 0;
        }

        public static double Min(params double[] values)
        {
            return 0;
        }

        public static double Min(params long[] values)
        {
            return 0;
        }

        public static double Min(params ulong[] values)
        {
            return 0;
        }

        [Template("Bridge.Decimal.min({*values})")]
        public static extern decimal Min(params decimal[] values);

        public static double Random()
        {
            return 0;
        }

        public static double Sqrt(double x)
        {
            return 0;
        }

        [Template("{d}.ceil()")]
        public static extern decimal Ceiling(decimal d);

        [Name("ceil")]
        public static extern double Ceiling(double d);

        public static double Floor(double x)
        {
            return 0;
        }

        [Template("{d}.floor()")]
		public static extern decimal Floor(decimal d);

        public static double Round(double x)
        {
            return 0;
        }

        [Template("Bridge.Decimal.round({x}, 1)")]
        public static decimal Round(decimal x)
        {
            return 0;
        }

        [Template("Bridge.Decimal.round({d}, {method})")]
        public static extern decimal Round(decimal d, MidpointRounding method);

        public static double Exp(double x)
        {
            return 0;
        }

        [Template("{x}.exponential()")]
        public static decimal Exp(decimal x)
        {
            return 0;
        }

        [Template("{x}.ln()")]
        public static decimal Ln(decimal x)
        {
            return 0;
        }

        [Template("{x}.log({logBase})")]
        public static decimal Log(decimal x, decimal logBase)
        {
            return 0;
        }

        [Template("{x}.pow({y})")]
        public static decimal Pow(decimal x, decimal y)
        {
            return 0;
        }

        [Template("{x}.sqrt()")]
        public static decimal Sqrt(decimal x)
        {
            return 0;
        }

        public static double Log(double x)
        {
            return 0;
        }

        public static double Pow(double x, double y)
        {
            return 0;
        }

        public static double Acos(double x)
        {
            return 0;
        }

        public static double Asin(double x)
        {
            return 0;
        }

        public static double Atan(double x)
        {
            return 0;
        }

        public static double Atan2(double y, double x)
        {
            return 0;
        }

        public static double Cos(double x)
        {
            return 0;
        }

        public static double Sin(double x)
        {
            return 0;
        }

        public static double Tan(double x)
        {
            return 0;
        }

        [Template("Bridge.Int.trunc({d})")]
        public static extern double Truncate(double d);

        [Template("{d}.trunc()")]
        public static extern decimal Truncate(decimal d);

        [Template("{value}.sign()")]
        public static extern int Sign(decimal value);
    }
}