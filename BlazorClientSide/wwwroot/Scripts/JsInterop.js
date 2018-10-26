

window.exampleJsFunctions = {
    showPrompt: function (message) {
        return prompt(message, 'Type anything here');
    }
};


window.GreetingFunction = {
    showalert: function () {
        alert("Hello Csharpcorner");
    }
};


function CSMethod() {
    DotNet.invokeMethodAsync('BlazorClientSide', 'CSCallBackMethod');
}

