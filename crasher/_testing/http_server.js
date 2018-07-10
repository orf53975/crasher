var http = require('http');
var connections = 0;
var seconds = 0;

console.log("Server started..");

//Connection status manager (timer every second)
var secondCounter = setInterval(function () {
    console.clear();
    if (connections > 0) {
        seconds++;
        WriteStatus();
    } else {
        console.log("No requests.. YET!!");
    }
}, 1000);

//create a server object:
http.createServer(function (request, response) {
    //2 requests: 1 for the page, 1 for the favicon
    connections++;
}).listen(80); //the server object listens on port 8080

//Requests per second counter
function WriteStatus() {
    var requestsPerSecond = connections / seconds;
    console.log("Total requests: " + connections);
    console.log(requestsPerSecond + " requests/s");
}