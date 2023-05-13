# Vendor and Order Tracker

#### This is an application that allows a business to enter vendors and orders to keep track of their clients and supply needs

#### By Christopher Ross Davila

## Technologies Used

* _dot net 6_
* _cshtml_
* _C#_
* _ASP.NET Core_
* _MS Build_


## Description

This application is a demonstration of using MVC file structure and RESTful routing to deploy a website with multiple connected pages. Users can access the home page and depending on needs can add as many vendors as desired, and add as many orders to each vendor as desired.  Vendors objects have properties for vendor name, description and address that can be applied and Order objects will have properties for title, description, price and date.

## Setup/Installation Requirements

* _1. Clone this repo using `\$ git clone https://github.com/ChrisRDavila/Vendor-And-Order-Tracker.Solution.git`_
* _2. Open your terminal (e.g., Terminal or GitBash) and navigate to the production directory called "Vendor-and-order-tracker.solution" and use command `\$ code .` to open project in vs code._
* _3. From inside the VendorAndOrder directory run `\$ dotnet build` to compile and build the app._
* _4. From the VendorOrderTracker.Tests directory run the command `\$ dotnet test` to run tests._
* _5. From inside the VendorAndOrder directory use `\$ dotnet watch run` to start or cycle the server_
* _6. Once a server is opened up select link desired to navigate app, most likely add a vendor to start_
* _7. From vendor/new page enter needed information to create a new vendor_
* _8. From vendors/index select a vender to view, go to vendor entry page or return to home page_
* 9. From selected vendor can choose to add new order, view and order if order exists, return to vendor list, or return to main page_
* 10. from selected order (order details page) view order details, add another order  or return to view all vendors

## Known Bugs

* _need to change price to a float, anything entered with decimal will return 0_


## License
[MIT](https://github.com/ChrisRDavila/Vendor-And-Order-Tracker.Solution/blob/main/License.txt)