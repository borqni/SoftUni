function test([sum, input, output]) {
    sum = Number(sum);
    let lev = 1;
    let dolar = 1.79549;
    let euro = 1.95583;
    let lira = 2.53405;

    let resultInput = 0;
    if (input == "BGN") {
        resultInput = sum * lev;
    } else if (input == 'USD') {
        resultInput = sum * dolar;
    } else if (input == 'EUR') {
        resultInput = sum * euro;
    } else if (input == 'GBP') {
        resultInput = sum * lira;
    }

    let rezultOutput = 0;
    if (output == 'BGN') {
        rezultOutput = resultInput / lev;
    } else if (output == 'USD') {
        rezultOutput = resultInput / dolar;
    } else if (output == 'EUR') {
        rezultOutput = resultInput / euro;
    } else if (output == 'GBP') {
        rezultOutput = resultInput / lira;
    }

    console.log(rezultOutput.toFixed(2) + ' ' + output);
}