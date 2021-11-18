# Tolitech.CodeGenerator.Notification
Notifications library used in projects created by the Code Generator tool.

This project allows to simplify the communication and message return between the domain and the presentation layer, allowing that validation errors, business or messages of any other nature can be recovered and used as needed.

In other words, we expose an object that collects together information about errors and other information in the domain layer and communicates it to the presentation.

Tolitech Code Generator Tool: [http://www.tolitech.com.br](https://www.tolitech.com.br/)

Examples:

```
var person = new Person("Name");
bool isValid = person.IsValid();
```

```
var result = new NotificationResult();
result.AddMessage("message");
```

```
var result = new NotificationResult();
result.AddError(new Exception("exception"));
```

In unit tests, it is possible to know the dozens of variations and possibilities that exist between notifications of error, success, warning and the traffic of other objects and relevant information. 
