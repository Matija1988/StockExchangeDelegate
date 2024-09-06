# StockExchangeDelegate
 
This small console application demonstrates a Delegate being used as an Alert system in a Stock simulation.

In the project Stocks are generated in a endless loop until value of one of the stock drops for 2%, an arbitrary value. 
When this condition is met loops stops and writes the alert message in console notifying the owners of the stock. 

This project contains the aforementioned delegate, records and LINQ example.

Result example

NAME: Intel     VALUE: 101      DATE: 2023-05-07
NAME: Apple     VALUE: 111      DATE: 2023-05-07
NAME: Google    VALUE: 96       DATE: 2023-05-07
NAME: Intel     VALUE: 102      DATE: 2023-05-08
NAME: Apple     VALUE: 97       DATE: 2023-05-08
ALERT: Apple has dropped by 2% or more!
Sending notification to Ivan Grozny
Sending notification to Tim Timmy
