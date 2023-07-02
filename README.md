# FikValidationKit

# How to use

            IValidationService items = new ValidationManager(new FikValidationErrorMessagesTr());
            Product product = new Product(1,"");

            var result=Validation.Validate(
                items.NotEmpty(null)
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



![Working](https://user-images.githubusercontent.com/61146337/162179825-861784b8-adb1-4c67-ae42-d7c20862fc4b.png)


![Tests](https://user-images.githubusercontent.com/61146337/162178650-d9cdaa89-e9da-450c-aaa8-3dc517621055.png)
Don't forget to write your tests while developing
