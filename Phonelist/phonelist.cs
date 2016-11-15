using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace Phonelist
{
    /// <summary>
    /// Phonelist - Working 
    /// 
    /// Given a list of phone numbers, determine if it is consistent in the sense that no number is the prefix of another. 
    /// Let’s say the phone catalogue listed these numbers:
    ///
    /// - Emergency 911
    /// - Alice 97 625 999
    /// - Bob 91 12 54 26
    ///
    /// In this case, it’s not possible to call Bob, because the central would direct your call to the emergency line as soon 
    /// as you had dialled the first three digits of Bob’s phone number.So this list would not be consistent.
    /// </summary>

    class Program

    {

        static void Main(string[] args)

        {

            Solve(Console.OpenStandardInput(), Console.OpenStandardOutput());

        }

        public static void Solve(Stream stdin, Stream stdout)
        {
            IScanner scanner = new OptimizedPositiveIntReader(stdin);

            // uncomment when you need more advanced reader

            // scanner = new Scanner(stdin);

            scanner = new LineReader(stdin);

            BufferedStdoutWriter writer = new BufferedStdoutWriter(stdout);



            var numberOfTestCases = scanner.NextInt();



            for (int i = 0; i < numberOfTestCases; i++)

            {



                var result = Solve(scanner);

                writer.Write(result);

                writer.Write("\n");

            }



            writer.Flush();

        }



        private static string Solve(IScanner scanner)

        {

            int numberOfPhoneNumbers = scanner.NextInt();

            Program.PhoneNode phoneBook = new Program.PhoneNode(String.Empty, false);

            string answer = null;



            for (int j = 0; j < numberOfPhoneNumbers; j++)

            {

                var no = scanner.Next();

                Debug.WriteLine("Processing: " + no);



                if (answer != null)

                    continue;



                var current = phoneBook;



                for (int index = 0; index < no.Length; index++)

                {

                    var digit = no[index] - '0';

                    if (current.Nodes[digit] == null)

                        current.Nodes[digit] = new PhoneNode(current.Id + digit, index == no.Length - 1);

                    else if (index == no.Length - 1 || current.Nodes[digit].IsStop)

                    {

                        // if this is my last digit and number already used - 'NO'

                        // if some other number finished here - 'NO'



                        // number already exists

                        answer = "NO";

                        break;

                    }

                    current = current.Nodes[digit];

                }

            }

            return answer ?? "YES";

        }



        public class PhoneNode

        {

            public override string ToString()

            {

                return Id;

            }



            public PhoneNode(string id, bool isStop)

            {

                Id = id;

                IsStop = isStop;

            }



            public string Id;

            public PhoneNode[] Nodes = new PhoneNode[10];

            public bool IsStop;

        }

    }

    public class Tokenizer
    {
        string[] tokens = new string[0];
        private int pos;
        StreamReader reader;

        public Tokenizer(Stream inStream)
        {
            var bs = new BufferedStream(inStream);
            reader = new StreamReader(bs);
        }

        public Tokenizer()
            : this(Console.OpenStandardInput())
        {
            // Nothing more to do
        }

        private string PeekNext()
        {
            if (pos < 0)
                // pos < 0 indicates that there are no more tokens
                return null;
            if (pos < tokens.Length)
            {
                if (tokens[pos].Length == 0)
                {
                    ++pos;
                    return PeekNext();
                }
                return tokens[pos];
            }
            string line = reader.ReadLine();
            if (line == null)
            {
                // There is no more data to read
                pos = -1;
                return null;
            }
            // Split the line that was read on white space characters
            tokens = line.Split(null);
            pos = 0;
            return PeekNext();
        }

        public bool HasNext()
        {
            return (PeekNext() != null);
        }

        public string Next()
        {
            string next = PeekNext();
            if (next == null)
                throw new NoMoreTokensException();
            ++pos;
            return next;
        }
    }

    public class Scanner : Tokenizer, IScanner
    {

        public Scanner(Stream inStream)
            : base(inStream)
        {
        }

        public int NextInt()
        {
            return int.Parse(Next());
        }

        public long NextLong()
        {
            return long.Parse(Next());
        }

        public float NextFloat()
        {
            return float.Parse(Next());
        }

        public double NextDouble()
        {
            return double.Parse(Next());
        }
    }

    public class NoMoreTokensException : Exception
    {
    }

    public interface IScanner
    {
        int NextInt();
        long NextLong();
        float NextFloat();
        double NextDouble();
        bool HasNext();
        string Next();
    }

    public class BufferedStdoutWriter : StreamWriter
    {
        public BufferedStdoutWriter(Stream outStream)
            : base(new BufferedStream(outStream))
        {
        }
    }

    public class OptimizedPositiveIntReader : IScanner
    {
        private readonly StreamReader _reader;

        public OptimizedPositiveIntReader(Stream inStream)
        {
            _reader = new StreamReader(inStream);
        }

        public int NextInt()
        {
            int c, result = 0;
            bool isInt = false;
            while (!_reader.EndOfStream)
            {
                c = _reader.Read();

                while (c >= '0' && c <= '9')
                {
                    result = result * 10 + c - '0';
                    c = _reader.Read();
                    isInt = true;
                }

                if (isInt)
                    return result;
            }

            throw new NoMoreTokensException();
        }

        public long NextLong()
        {
            throw new NotImplementedException();
        }

        public float NextFloat()
        {
            throw new NotImplementedException();
        }

        public double NextDouble()
        {
            throw new NotImplementedException();
        }

        public bool HasNext()
        {
            throw new NotImplementedException();
        }

        public string Next()
        {
            throw new NotImplementedException();
        }
    }

    public class LineReader : IScanner
    {
        private readonly StreamReader _reader;

        public LineReader(Stream inStream)
        {
            _reader = new StreamReader(inStream);
        }

        public int NextInt()
        {
            return int.Parse(Next(), CultureInfo.InvariantCulture);
        }

        public long NextLong()
        {
            return Int64.Parse(Next(), CultureInfo.InvariantCulture);
        }

        public float NextFloat()
        {
            return float.Parse(Next(), CultureInfo.InvariantCulture);
        }

        public double NextDouble()
        {
            return Double.Parse(Next(), CultureInfo.InvariantCulture);
        }

        public bool HasNext()
        {
            return !_reader.EndOfStream;
        }

        public string Next()
        {
            return _reader.ReadLine();
        }
    }

}