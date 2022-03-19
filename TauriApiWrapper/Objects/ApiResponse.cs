using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects
{
    public class ApiResponse<T> where T : class
    {
        [JsonProperty(PropertyName = "success")]
        public bool IsSuccess { get; internal set; }

        [JsonProperty(PropertyName = "errorcode")]
        public int ErrorCode { get; internal set; }

        [JsonProperty(PropertyName = "errorstring")]
        public string ErrorMessage { get; internal set; }

        [JsonProperty(PropertyName = "response")]
        public T Response { get; internal set; }

        public CustomError? CustomError { get; internal set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public ApiResponse<T> ToApiResponse(string response)
        {
            return JsonConvert.DeserializeObject<ApiResponse<T>>(response);
        }
    }
}