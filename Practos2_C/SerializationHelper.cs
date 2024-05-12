using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Practos2_C
{
    public static class SerializationHelper
    {
        private const string FileName = "notes.json";

        public static void Serialize(this List<Note> notes)
        {
            File.WriteAllText(FileName, JsonConvert.SerializeObject(notes));
        }

        public static List<Note> Deserialize()
        {
            if (!File.Exists(FileName))
            {
                return new List<Note>();
            }

            return JsonConvert.DeserializeObject<List<Note>>(File.ReadAllText(FileName));
        }
    }
}
