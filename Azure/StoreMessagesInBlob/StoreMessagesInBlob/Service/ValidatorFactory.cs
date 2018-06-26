using StoreMessagesInBlob.Interfaces;
using StoreMessagesInBlob.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMessagesInBlob.Service
{
    public  class ValidatorFactory:AbstractValidatoFactory
    {
        public static IValidator GetValidator(IModel model)
        {
            IValidator returValidator = null;  //new DefualValidator();
            var typeOfModel = model.GetType();

            switch (model)
            {
                case Person s: returValidator = new Validator1();  break;
                case Customer s: returValidator = new Validator2(); break; 
                default:
                    break;
            }
            return returValidator;

        }
        public override  IValidator GetValidator<T>() 
        {
            IValidator returValidator = null;  //new DefualValidator();
            var type = typeof(T);

            if(typeof(Person) == type)
            {
                returValidator = new Validator1();

            }

           else if(typeof(Customer) == type)
            {
                returValidator = new Validator2();
            }

            return returValidator;

        }
        public static IValidator GetStaticValidator<T>()
        {
            IValidator returValidator = null;  //new DefualValidator();
            var type = typeof(T);

            if (typeof(Person) == type)
            {
                returValidator = new Validator1();

            }

            else if (typeof(Customer) == type)
            {
                returValidator = new Validator2();
            }

            return returValidator;

        }

        public void ble()
        {
            throw new NotImplementedException();
        }
    }
}
