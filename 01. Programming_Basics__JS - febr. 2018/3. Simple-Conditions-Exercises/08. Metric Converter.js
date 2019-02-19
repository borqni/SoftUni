function solve([num, input, output]) {
    let millimeter = 1000;
    let centimeters = 100;
    let miles = 0.000621371192;
    let inches = 39.3700787;
    let kilometers = 0.001;
    let feet = 3.2808399;
    let yards = 1.0936133;

    let resultInput = num;
    if (input == 'mm') {
        resultInput = num / millimeter;
    } else if (input == 'cm') {
        resultInput = num / centimeters;
    } else if (input == 'mi') {
        resultInput = num / miles;
    } else if (input == 'in') {
        resultInput = num / inches;
    } else if (input == 'km') {
        resultInput = num / kilometers;
    } else if (input == 'ft') {
        resultInput = num / feet;
    } else if (input == 'yd') {
        resultInput = num / yards;
    }

    let rezultOutput = resultInput;
    if (output == 'mm') {
        rezultOutput = resultInput * millimeter;
    } else if (output == 'cm') {
        rezultOutput = resultInput * centimeters;
    } else if (output == 'mi') {
        rezultOutput = resultInput * miles;
    } else if (output == 'in') {
        rezultOutput = resultInput * inches;
    } else if (output == 'km') {
        rezultOutput = resultInput * kilometers;
    } else if (output == 'ft') {
        rezultOutput = resultInput * feet;
    } else if (output == 'yd') {
        rezultOutput = resultInput * yards;
    }

    console.log(rezultOutput + ' ' + output);
}