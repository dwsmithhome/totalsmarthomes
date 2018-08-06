

using totalsmarthomes.Models.Base;

namespace totalsmarthomes.Models.Interfaces
{
    public interface IBaseViewModel<out T> where T : BaseModel
    {
        
    }
}