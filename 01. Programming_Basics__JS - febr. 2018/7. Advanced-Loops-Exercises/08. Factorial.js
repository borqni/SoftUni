function test([n]) {
    let factorial = 1;

    do {
        factorial *= n--;
    } while (n > 1) {
        console.log(factorial);
    }
}