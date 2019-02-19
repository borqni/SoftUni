function test([n]) {
    n = Number(n);
    let stars = 1;
    if (n % 2 == 0) {
        stars = 2;
    }

    for (let row = 0; row < Math.ceil(n / 2); row++) {
        console.log(`${'-'.repeat(((n-stars)/2)-row)}${'*'.repeat(stars+2*row)}${'-'.repeat(((n-stars)/2)-row)}`)
    }

    for (let row = 0; row < Math.floor(n / 2); row++) {
        console.log(`|${'*'.repeat(n-2)}|`);
    }
}