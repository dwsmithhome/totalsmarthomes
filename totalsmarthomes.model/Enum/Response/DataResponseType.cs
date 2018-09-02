namespace StoreFront.Model.Enum.Response
{
    public enum DataResponseType
    {
        NONE = 0,
        SUCCESS = 1,
        MISSING_DATA = 2,
        ITEM_NOT_FOUND = 3,
        DATA_INSERT_ERROR = 4,
        UNHANDLED_ERROR = 5,
        DATA_UPDATE_ERROR = 6,
        DATA_DELETE_ERROR = 7,
        UNAUTHENTICATED = 8
    }
}