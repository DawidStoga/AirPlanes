using StoreMessagesInBlob.Interfaces;
using StoreMessagesInBlob.Model;

namespace StoreMessagesInBlob.Service
{
    public  abstract class AbstractValidatoFactory
    {
        abstract public IValidator GetValidator<T>() where T : IModel;
    }
}