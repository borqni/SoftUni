function test([n]) {
    n = Number(n);

    if (n <= 2) {
        console.log('*'.repeat(n));
        return;
    }

    let stars = 1;
    let height = Math.floor(n / 2);
    let midlDash = '-';

    if (n % 2 == 0) {
        stars = 2;
        height = (n / 2) - 1;
        midlDash = '--';
    }

    let dashes = (n - stars) / 2;

    console.log('-'.repeat(dashes) + '*'.repeat(stars) + '-'.repeat(dashes));

    for (let row = 1; row < height; row++) {
        console.log('-'.repeat(dashes - row) + '*' + midlDash + '*' +
            '-'.repeat(dashes - row));


        midlDash += '--';
    }

    console.log(`*${midlDash}*`);

    for (let row = 1; row < height; row++) {
        console.log('-'.repeat(row) + '*' + '-'.repeat(n - 2 - row * 2) + '*' + '-'.repeat(row));

        midlDash += '--';
    }

    console.log('-'.repeat(dashes) + '*'.repeat(stars) + '-'.repeat(dashes));
}