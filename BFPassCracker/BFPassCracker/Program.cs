using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFPassCracker
{
    class Program
    {

        static readonly string chars = "!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~";
        static string PassAttempter(string Password)
        {
            string pass = "";
            int passlenght = 8;
            double maxattempt = Math.Pow(92, passlenght);
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            Passrunner(passlenght, ref  pass, maxattempt, Password);
            stopWatch.Stop();

            #region Stopwatch Shower
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.WriteLine("RunTime " + elapsedTime);
            #endregion

            return pass;
        }

        static string Passrunner(int passlenght, ref string pass, double maxattempt, string Password)
        {
            int attempt = 0;
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0, i = 0, j = 0, k = 0, l = 0, m = 0, n = 0, o = 0, p = 0;

            do
            {
                pass = "";


                PassCreator(ref pass, chars, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, passlenght);
                CharCounter(ref a, ref b, ref c, ref d, ref e, ref f, ref g, ref h, ref i, ref j, ref k, ref l, ref m, ref n, ref o, ref p, passlenght);

                ++attempt;
                //Console.WriteLine(pass);

                if (maxattempt == attempt)
                {
                    maxattempt = maxattempt * 92;
                    attempt = 0;
                    ++passlenght;
                    if (passlenght > 16)
                    {
                        break;
                    }
                    break;
                }
                Console.WriteLine(pass);
            } while (pass != Password);

            return pass;
        }

        static string PassCreator(ref string pass, string chars, int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k, int l, int m, int n, int o, int p, int passlenght)
        {
            pass = pass + chars[i] + chars[j] + chars[k] + chars[l] + chars[m] + chars[n] + chars[o] + chars[p];
            if (passlenght > 9)
            {
                pass = chars[h] + pass;
                if (passlenght > 10)
                {
                    pass = chars[g] + pass;
                    if (passlenght > 11)
                    {
                        pass = chars[f] + pass;
                        if (passlenght > 12)
                        {
                            pass = chars[e] + pass;
                            if (passlenght > 13)
                            {
                                pass = chars[d] + pass;
                                if (passlenght > 14)
                                {
                                    pass = chars[c] + pass;
                                    if (passlenght > 15)
                                    {
                                        pass = chars[b] + pass;
                                        if (passlenght > 16)
                                        {
                                            pass = chars[a] + pass;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return pass;
        }

        static void CharCounter(ref int a, ref int b, ref int c, ref int d, ref int e, ref int f, ref int g, ref int h, ref int i, ref int j, ref int k, ref int l, ref int m, ref int n, ref int o, ref int p, int passlenght)
        {
            ++p;
            if (p == 92 || o == 92 || n == 92 || m == 92 || l == 92 || k == 92 || j == 92 || i == 92 || h == 92 || g == 92 || f == 92 || e == 92 || d == 92 || c == 92 || b == 92 || a == 92)
            {
                #region Pass has 8 chars
                if (p == 92)
                {
                    ++o;
                    p = 0;
                }
                if (o == 92)
                {
                    ++n;
                    o = 0;
                }
                if (n == 92)
                {
                    ++m;
                    n = 0;
                }
                if (m == 92)
                {
                    ++l;
                    m = 0;
                }
                if (l == 92)
                {
                    ++k;
                    l = 0;
                }
                if (k == 92)
                {
                    ++j;
                    k = 0;
                }
                if (j == 92)
                {
                    ++i;
                    j = 0;
                }
                #endregion
                #region Pass longer than 8
                if (passlenght > 9)
                {
                    if (i == 92)
                    {
                        ++h;
                        i = 0;
                    }
                    if (passlenght > 10)
                    {
                        if (h == 92)
                        {
                            ++g;
                            h = 0;
                        }
                        if (passlenght > 11)
                        {
                            if (g == 92)
                            {
                                ++f;
                                g = 0;
                            }
                            if (passlenght > 12)
                            {
                                if (f == 92)
                                {
                                    ++e;
                                    f = 0;
                                }
                                if (passlenght > 13)
                                {
                                    if (e == 92)
                                    {
                                        ++d;
                                        e = 0;
                                    }
                                    if (passlenght > 14)
                                    {
                                        if (d == 92)
                                        {
                                            ++c;
                                            d = 0;
                                        }
                                        if (passlenght > 15)
                                        {
                                            if (c == 92)
                                            {
                                                ++b;
                                                c = 0;
                                            }
                                            if (passlenght > 16)
                                            {
                                                if (b == 92)
                                                {
                                                    ++a;
                                                    b = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion
            }
        }

        static void Main(string[] args)
        {
            const string Password = "!!!!!aaa";
            string passcheck = PassAttempter(Password);

            if (passcheck == Password)
            {
                Console.Write("Pass is cracked. Password is: ");
                Console.WriteLine(passcheck);
            }
            else
            {
                Console.WriteLine("Pass is not cracked.");

            }

        }
    }
}
