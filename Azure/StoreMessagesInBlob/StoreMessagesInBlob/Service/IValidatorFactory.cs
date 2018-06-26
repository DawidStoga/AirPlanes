using StoreMessagesInBlob.Interfaces;
using StoreMessagesInBlob.Model;

namespace StoreMessagesInBlob.Service
{
    public interface IValidatorFactory
    {

          IValidator  GetValidator<T>() where T : IModel;
    }
}