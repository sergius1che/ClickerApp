# ClickerApp

Simple app to press virtual keys ([see](https://docs.microsoft.com/ru-ru/windows/desktop/inputdev/virtual-key-codes)) from javascript.

### Use

Run app: `ClickerHost 9876`, where 9876 - port to listen

Then send http request from JS:
```javascript
fetch("http://localhost:9876/?key=112")
  .then(response => response.text())
  .then(result => console.log(result))
  .catch(e => console.log(e));
```
