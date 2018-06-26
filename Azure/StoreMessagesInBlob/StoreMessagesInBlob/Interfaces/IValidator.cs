using StoreMessagesInBlob.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMessagesInBlob.Interfaces
{
    public interface IValidator
    {
        string Validate(IModel model);
        string Validate();
    }
}
