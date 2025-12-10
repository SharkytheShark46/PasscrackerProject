namespace BFPasswordCracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string password = "!!!!!@@@";
            string passOut;

            List<char> pass = new List<char> { (char)33, (char)33, (char)33, (char)33, (char)33, (char)33, (char)33, (char)33 };
            do
            {
                passOut = CharCombiner(pass);
                Console.WriteLine(passOut);
            } while (password != passOut);
            Console.WriteLine($"Password is {passOut}");
        }

        static string CharCombiner(List<char> pass)
        {
            string password = "";

            for (int i = 0; i < pass.Count - 1; i++)
            {
                password += pass[i];
            }
            password += pass[pass.Count - 1];
            CharSetter(pass);
            return password;
        }

        static void CharSetter(List<char> pass)
        {
            pass[pass.Count - 1] = (char)((int)pass[pass.Count - 1] + 1);
            if ((int)pass[pass.Count - 1] == 127)
            {
                pass[pass.Count - 1] = (char)33;
                pass[pass.Count - 2] = (char)((int)pass[pass.Count - 2] + 1);
                if ((int)pass[pass.Count - 2] == 127)
                {
                    pass[pass.Count - 2] = (char)33;
                    pass[pass.Count - 3] = (char)((int)pass[pass.Count - 3] + 1);
                    if ((int)pass[pass.Count - 3] == 127)
                    {
                        pass[pass.Count - 3] = (char)33;
                        pass[pass.Count - 4] = (char)((int)pass[pass.Count - 4] + 1);
                        if ((int)pass[pass.Count - 4] == 127)
                        {
                            pass[pass.Count - 4] = (char)33;
                            pass[pass.Count - 5] = (char)((int)pass[pass.Count - 5] + 1);
                            if ((int)pass[pass.Count - 5] == 127)
                            {
                                pass[pass.Count - 5] = (char)33;
                                pass[pass.Count - 6] = (char)((int)pass[pass.Count - 6] + 1);
                                if ((int)pass[pass.Count - 6] == 127)
                                {
                                    pass[pass.Count - 6] = (char)33;
                                    pass[pass.Count - 7] = (char)((int)pass[pass.Count - 7] + 1);
                                    if ((int)pass[pass.Count - 7] == 127)
                                    {
                                        pass[pass.Count - 7] = (char)33;
                                        pass[pass.Count - 8] = (char)((int)pass[pass.Count - 8] + 1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
