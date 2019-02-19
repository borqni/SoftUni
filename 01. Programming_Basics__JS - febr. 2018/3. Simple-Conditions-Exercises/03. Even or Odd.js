function solve([number]) {
    number = Number(number);
    if (number % 2 === 0) {
        console.log('even');
    }
    if (number % 2 != 0) {
        console.log('odd');
    }
}