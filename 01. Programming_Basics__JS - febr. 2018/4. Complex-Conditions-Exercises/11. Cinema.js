function cinema([input1, input2, input3]) {
    var type = input1
    var rows = Number(input2)
    var columns = Number(input3)
    var result
    var resultString

    switch (type) {
        case "Premiere":
            result = rows * columns * 12
            resultString = result.toFixed(2)
            console.log(resultString);
            break;
        case "Normal":
            result = rows * columns * 7.5
            resultString = result.toFixed(2)
            console.log(resultString);
            break;
        case "Discount":
            result = rows * columns * 5
            resultString = result.toFixed(2)
            console.log(resultString);
            break;
    }
}