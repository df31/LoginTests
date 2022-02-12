## LoginCypressTest

### Install Cypress and plugins

Navigate to LoginComponentCypressTest then run:

```shell
npm install
```

### Exectute all the tests

```shell
cypress run
```

## LoginSeleniumTest

### Build and Run tests

Navigate to LoginComponentSeleniumTest then run:

```shell
dotnet test
```
### Install SpecFlow+LivingDoc CLI
```shell
dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
```
### Generate HTML test report
```shell
livingdoc.exe test-assembly LoginComponentTest/bin/Debug/netcoreapp3.1/LoginComponentTest.dll -o LoginTestReport.html
```
