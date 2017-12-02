using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2017
{
    public abstract class Puzzle<T>
    {
        private readonly int _day;
        private readonly string _inputFileName;
        private readonly bool _inputCached;

        private const string SessionId = "53616c7465645f5f3408ba5c57b3f265a08a6396cfcb5a9ee83a3e0cd031b04e08a6dd5fc2ed2f203b4021a434437a35";

        public Puzzle(int day)
        {
            _day = day;
            _inputFileName = $"{Directory.GetCurrentDirectory()}/Day{_day}/input.txt";
            _inputCached = File.Exists(_inputFileName);
        }

        public abstract T Answer(string input);

        public async Task<string> GetInput()
        {
            if (!_inputCached)
            {
                var request = WebRequest.Create($"http://adventofcode.com/2017/day/{_day}/input") as HttpWebRequest;
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(new Cookie("session", SessionId, "/", request.Host));
                var url = $"http://adventofcode.com/2017/day/{_day}/input";
                var response = await request.GetResponseAsync();
                using (var fileStream = File.Create(_inputFileName))
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        var result = await reader.ReadToEndAsync();

                        using (var writer = new StreamWriter(fileStream))
                        {
                            await writer.WriteLineAsync(result);
                        }
                    }
                }
            }

            byte[] data;
            using (var reader = File.Open(_inputFileName, FileMode.Open))
            {
                data = new byte[reader.Length];
                await reader.ReadAsync(data, 0, (int)reader.Length);
            }
            return Encoding.ASCII.GetString(data);
        }
    }
}
