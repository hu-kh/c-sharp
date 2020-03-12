```c#


Digits after decimal point
// just two decimal places
String.Format("{0:0.00}", 123.4567);      // "123.46"
String.Format("{0:0.00}", 123.4);         // "123.40"
String.Format("{0:0.00}", 123.0);         // "123.00"

// max. two decimal places
String.Format("{0:0.##}", 123.4567);      // "123.46"
String.Format("{0:0.##}", 123.4);         // "123.4"
String.Format("{0:0.##}", 123.0);         // "123"
// at least two digits before decimal point
String.Format("{0:00.0}", 123.4567);      // "123.5"
String.Format("{0:00.0}", 23.4567);       // "23.5"
String.Format("{0:00.0}", 3.4567);        // "03.5"
String.Format("{0:00.0}", -3.4567);       // "-03.5"

Thousands separator
String.Format("{0:0,0.0}", 12345.67);     // "12,345.7"
String.Format("{0:0,0}", 12345.67);       // "12,346"

Zero
Following code shows how can be formatted a zero (of double type).

String.Format("{0:0.0}", 0.0);            // "0.0"
String.Format("{0:0.#}", 0.0);            // "0"
String.Format("{0:#.0}", 0.0);            // ".0"
String.Format("{0:#.#}", 0.0);            // ""

Align numbers with spaces
String.Format("{0,10:0.0}", 123.4567);    // "     123.5"
String.Format("{0,-10:0.0}", 123.4567);   // "123.5     "
String.Format("{0,10:0.0}", -123.4567);   // "    -123.5"
String.Format("{0,-10:0.0}", -123.4567);  // "-123.5    "

Custom formatting for negative numbers and zero
String.Format("{0:0.00;minus 0.00;zero}", 123.4567);   // "123.46"
String.Format("{0:0.00;minus 0.00;zero}", -123.4567);  // "minus 123.46"
String.Format("{0:0.00;minus 0.00;zero}", 0.0);        // "zero"

Some funny examples
String.Format("{0:my number is 0.0}", 12.3);   // "my number is 12.3"
String.Format("{0:0aaa.bbb0}", 12.3);
```
