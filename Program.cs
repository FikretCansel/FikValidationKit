using System;
using FikValidation.FikValidation;
using FikValidation.FikValidation.Messages;

namespace FikValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IValidationService items = new ValidationManager(new FikValidationErrorMessagesTr());

            Product product = new Product(1,"");

            

            var result=Validation.Validate(
                items.NotEmpty(product.Name)
                ,items.GraterThan(10, 5),items.IsEquals(product.Name,"Fikret"),
                bussinessRule(), bussinessRule2());


            if (!result.IsSuccess)
            {
                Console.WriteLine("Bad Request");
            }
            Console.WriteLine(result.IsSuccess);
            Console.WriteLine(result.Message);

            FikEntity bussinessRule()
            {
                return new FikEntity(false);
            }
            FikEntity bussinessRule2()
            {
                return new FikEntity(false);
            }

        }

    }
}
