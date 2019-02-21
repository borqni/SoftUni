function solve(input) {
    let number = +input[0];

    for (let i = 1; i <= 5; i++) {
        let command = input[i];

        if (command === 'chop') {
            number /= 2;
            console.log(number);
        } else if (command === 'dice') {
            number = Math.sqrt(number);
            console.log(number);
        } else if (command === 'spice') {
            number += 1;
            console.log(number);
        } else if (command === 'bake') {
            number *= 3;
            console.log(number);
        } else if (command === 'fillet') {
            number *= 0.8;
            console.log(number.toFixed(1));
        }
    }
}