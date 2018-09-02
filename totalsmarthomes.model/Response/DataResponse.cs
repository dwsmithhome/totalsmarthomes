using StoreFront.Model.Enum.Response;

namespace StoreFront.Model.Response
{
    public class DataResponse
    {
        public DataResponseType Type { get; set; }

        private string _details;
        public string Details
        {
            get
            {
                return _details ?? Type.ToString();
            }
            set
            {
                _details = value;
            }
        }
    }
}