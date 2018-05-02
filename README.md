## SPEX

The program should include authentication for users

The program should have authorization/roles
* Manager
* Salesperson

The program should allow creation of products (Product Model)
The program should track sales (Sale Model)



Salesperson

* See complete inventory to help customers
* Make a sale, which reduces inventory and increases revenue
* Process a return which returns an item to inventory and credits a refund

Login as a sales associate or a manager.

As a sales associate I can perform the following actions on a single page using AJAX.

see complete inventory to help customers
make a sale, which reduces inventory and increases revenue
process a return which returns an item to inventory and credits a refund
see all of my sales, and make comments that only I can see
calculate my commission based on my individual sales

As a manager I can perform the following actions on a single page using AJAX

see inventory AND costs for inventory items
review and edit sales by all sales associates, to correct for errors
view sales associate comments on sales
see commission for all sales associates
add or remove sales associates
add new inventory for sale, including item cost and sale price
see the total balance sheet for the entire store (revenue - costs = profit)
Be sure to write unit tests for all of your actions. This is a good opportunity to practice using a mock database or a test database.
