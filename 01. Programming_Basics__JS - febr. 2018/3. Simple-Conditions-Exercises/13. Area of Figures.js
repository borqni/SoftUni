function test(arg) {
    let tip = arg[0];
    let a = Number(arg[1]);
    let b = Number(arg[2]);
    let area = 0;

    if (tip == 'square') {
        area = a * a;
    } else if (tip == 'rectangle') {
        area = a * b;
    } else if (tip == 'circle') {
        area = Math.PI * a * a;
    } else if (tip == 'triangle') {
        area = (a * b) / 2;
    }

    console.log(area)
}