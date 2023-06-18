# Dynamic Helper

## Overview
The `CaseInsensitiveDynamic` class is a custom implementation of `DynamicObject` in C#. It allows for case-insensitive property access on an underlying object. This class is useful when you need to access properties dynamically without being case-sensitive.

The `CheckIsDynamicPropertyExist` class provides a utility method to check whether a property exists on a dynamic object.

## Getting Started
To use the `CaseInsensitiveDynamic` and `CheckIsDynamicPropertyExist` classes in your project, follow these steps:

1. Copy the code provided into your project.

2. Ensure that the following namespaces are included:
   ```csharp
   using Microsoft.CSharp.RuntimeBinder;
   using System.Dynamic;
To create a `CaseInsensitiveDynamic` object, pass an existing object as a parameter to the constructor. This object will serve as the underlying properties for the dynamic access.

    dynamic dynamicObject = new CaseInsensitiveDynamic(myObject);
    var value = dynamicObject.MyProperty;

To check if a property exists on a dynamic object, use the CheckIsDynamicPropertyExist.IsPropertyExist method. Pass the dynamic object and the property name as parameters. The method returns true if the property exists and false otherwise.

    bool exists = CheckIsDynamicPropertyExist.IsPropertyExist(dynamicObject, "MyProperty");

## Dependencies

The code does not have any external dependencies.

## Contributing

Contributions to the `CaseInsensitiveDynamic` and `CheckIsDynamicPropertyExist` classes are welcome. If you find any issues or have improvements to suggest, please feel free to open an issue or submit a pull request.

## License

This code is licensed under the [MIT License](LICENSE).

Feel free to modify and use the code in accordance with the license terms.

## Credits

The `CaseInsensitiveDynamic` and `CheckIsDynamicPropertyExist` classes were developed by Muhammad Ali.
