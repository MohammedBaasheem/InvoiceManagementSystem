 Invoice Management System

This project implements a simple invoice management system demonstrating the use of several design patterns.  The system handles customers, items, and generates invoices with discounts based on customer category and shopping cart type.

## Project Structure

The project is structured into several core components:

*   **Core:** Contains the core business logic and entities of the system.
*   **Core.DiscountStrategies:** Houses the different discount strategies.
*   **Core.ShoppingCarts:** Defines different shopping cart types and their specific logic.
*   **StrategyDesignPattern:** Contains the factory for creating discount strategies.

## Design Patterns Used

This project utilizes the following design patterns:

1.  **Strategy Pattern:** The `ICustomerDiscountStrategy` interface and its concrete implementations (`GoldCustomerDiscountStrategy`, `SilverCustomerDiscountStrategy`, `NullDiscountStrategy`) represent the Strategy pattern. This pattern allows the discount calculation algorithm to be chosen at runtime based on the customer's category. The `InvoiceManager` uses this strategy to calculate discounts without needing to know the specific implementation.  This promotes flexibility and maintainability, allowing for easy addition of new discount strategies without modifying existing code.

2.  **Factory Pattern:** The `CustomerDiscountStrategyFactory` implements the Factory pattern. It's responsible for creating the appropriate discount strategy object based on the customer category. This pattern centralizes the strategy creation logic and decouples the client code from the concrete strategy classes.  This simplifies the process of adding new customer categories or changing existing ones.

3.  **Abstract Factory Pattern (Implicit):**  While not explicitly named, the combination of the `ShoppingCart` abstract class and its derived classes (`OnlineShoppingCart`, `InStoreShoppingCart`) along with the separate discount strategies can be seen as a form of Abstract Factory.  The shopping cart type (online or in-store) influences which discount logic is applied.  Although there isn't a dedicated Abstract Factory *class*, the *concept* is present.  The `ShoppingCart` acts as an abstract factory for creating related objects (in this case, the discount application logic).

4.  **Template Method Pattern:** The `ShoppingCart` abstract class and its `Checkout` method demonstrate the Template Method pattern. The `Checkout` method defines the overall process of checking out (adding items, applying taxes, applying discounts, and processing payment).  The `ApplyDiscount` method is declared as abstract, forcing the subclasses (`OnlineShoppingCart`, `InStoreShoppingCart`) to provide their own specific discount implementation. This ensures a consistent checkout process while allowing for variations in discount logic.

## How to Use

1.  Create a `Customer` object with the appropriate category.
2.  Create a `ShoppingCart` object (either `OnlineShoppingCart` or `InStoreShoppingCart`).
3.  Add items to the shopping cart using `AddItem`.
4.  Call the `Checkout` method on the shopping cart, passing in the `Customer` object.

The system will then calculate the total price, apply taxes, apply the appropriate discount based on the customer category and shopping cart type, and process the payment.

## Benefits of Using These Patterns

*   **Flexibility:**  New discount strategies and shopping cart types can be easily added without modifying existing code.
*   **Maintainability:** The code is more organized and easier to understand, making it easier to maintain and debug.
*   **Reusability:** The discount strategies and shopping cart components can be reused in other parts of the application.
*   **Testability:** Each component can be tested independently, making it easier to ensure the correctness of the system.
