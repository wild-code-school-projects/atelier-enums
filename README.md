# atelier-enums
ASP.NET MVC project that shows a list of product and their data.

Task Summary for Product Management

    Define Category Enumeration:
        Create an enumeration called Category to represent the various possible categories for products (e.g., Food, Clothing, Electronics).
        Add different categories as enum values.

    Create Product Class:
        Define a C# class named Product with the following properties:
            Id: Unique identifier of the product (primary key).
            Name: Name of the product.
            Description: Description of the product.
            Price: Price of the product.
            Category: Property of type Category representing the product's category.

    Populate Product List in ProductController:
        In the ProductController, create a list of products with different categories.
        Add various products with corresponding categories to the list.

    Display Products in Index View:
        Create an Index view within the Product controller to display the products.
        Utilize a loop (e.g., foreach loop) to iterate through the products and display them.
        Display the name of each category followed by the list of products belonging to that category.
