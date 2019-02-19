function convert([arg1]) {
    let usd = Number(arg1);
    let bgn = Number(usd * 1.79549).toFixed(2);

    console.log(bgn);
}