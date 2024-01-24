using YamlDotNet.Serialization;

namespace Logic
{
    public static class Loader
    {
        public static async Task LoadAsync(LexemeRepository repository)
        {
            using Stream stream = await FileSystem.OpenAppPackageFileAsync("lexemes.yaml");
            using StreamReader reader = new StreamReader(stream);
            IDeserializer deserializer = new DeserializerBuilder().Build();

            string contents = (string)reader.ReadToEnd();
            Dictionary<string, string> dictionary = deserializer.Deserialize<Dictionary<string, string>>(contents);

            if (dictionary != null)
            {
                foreach (KeyValuePair<string, string> record in dictionary)
                {
                    Lexeme word = new Lexeme(record.Key, record.Value);
                    repository.Append(word);
                }
            }
        }
    }
}
