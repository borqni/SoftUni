function solve(num) {
    let number = num.toString();
    let finalSum = sumDigits(number);

    function sumDigits(numb) {
        let sum = 0;
        for (let digit of numb) {
            sum += +digit;
        }
        return sum;
    }

    while (finalSum / number.length <= 5) {
        number += '9';
        finalSum = sumDigits(number);
    }

    console.log(number)
}

solve(101)