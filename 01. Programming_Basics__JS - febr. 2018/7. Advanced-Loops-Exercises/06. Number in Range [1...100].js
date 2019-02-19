function test(arg) {
    let i = 0;
    let n = Number(arg[i]);

    while (n < 1 || n > 100) {
        i++;
        console.log('Invalid Number!');
        n = Number(arg[i]);
    }

    console.log(`The number is: ${n}`)
}