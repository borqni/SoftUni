function sumNumbers(args) {
    let n = Number(args[0]);
    sum = 0;

    for (let i = 1; i <= n; i++) {
        sum = sum + Number(args[i]);
    }

    console.log(sum)
}