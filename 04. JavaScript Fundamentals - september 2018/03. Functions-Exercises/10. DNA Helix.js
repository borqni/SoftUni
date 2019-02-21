function solve(number) {
    let row = +number;
    let word = 'ATCGTTAGGG';
    let index = 0;

    for (let i = 0; i < row; i++) {
        if (index === word.length) {
            index = 0;
        }

        if (i % 4 === 0) {
            console.log(`**${word[index++]}${word[index++]}**`);
        } else if (i % 4 === 1 || i % 4 === 3) {
            console.log(`*${word[index++]}--${word[index++]}*`);
        } else {
            console.log(`${word[index++]}----${word[index++]}`);
        }
    }
}

solve(10)