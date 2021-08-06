> $ coyote --version

`Version: 1.3.1.0`

> $ coyote rewrite .\CoyoteUnitTesting.Tests\bin\Debug\netcoreapp3.1\CoyoteUnitTesting.dll

> $ dotnet --version

`5.0.301`

> $ dotnet test .\CoyoteUnitTesting.Tests\bin\Debug\netcoreapp3.1\CoyoteUnitTesting.Tests.dll

```
Error Message:
   System.IO.FileNotFoundException : Could not load file or assembly 'System.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'. The system cannot find the file specified.
  Stack Trace:
     at CoyoteUnitTesting.Tests.Tests.Running_CoyoteTest_ShouldWork()
```