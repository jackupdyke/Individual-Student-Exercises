# Driveway Masters Snow Removel Work Order

1. Create a new class that represents a *Work Order*.
2. Add a *name*, *length*, *width*, and *estimated total* property to the Work Order class:
    * `name`: indicates the name on the reservation.
    * `lenght` & `width`: indicates that area to be cleared in feet
    * `estimated total`: indicates the estimated total using `length` times `width` times a rate of $4.99 per 100 square feet.
3. Create a constructor that accepts `name`, `length`, and `width`.
4. Instantiate an object, or objects, in `Main()`, and use the object(s) to test your methods.
5. Create a method that calculates the actual total using two `bool` input parameters: `rush` and `icy`:
    * If the request is rush (2-hour response time), a fee of $16.98 is added to the estimated total.
    * If the area is icy, a fee of $24.75 is added to the estimated total.
    * The rush fee is doubled if the area is icy.
6. Override the `ToString()` method and have it return `"WORK ORDER - {name} - {estimated total}"` where `{name}` and `{estimated total}` are placeholders for the values from those properties. The values from the object should be shown in the string where `{variable-name}` is indicated.
7. Implement unit tests to validate the functionality of:
    * The estimated total calculation
    * The actual total method
