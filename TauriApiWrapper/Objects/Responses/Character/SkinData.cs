using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public class SkinData
    {
        [JsonProperty("skinstyle")]
        public int SkinStyle { get; set; }

        [JsonProperty("facecolor")]
        public int FaceColor { get; set; }

        [JsonProperty("hairstyle")]
        public int HairStyle { get; set; }

        [JsonProperty("haircolor")]
        public int HairColor { get; set; }

        [JsonProperty("facialhair")]
        public int FacialHair { get; set; }
    }
}