function gradusC([arg1]) {
    let grC = Number(arg1);
    let grF = Number((grC * 1.8 + 32));
    let calc = Math.round(grF * 100) / 100;

    console.log(calc);
}