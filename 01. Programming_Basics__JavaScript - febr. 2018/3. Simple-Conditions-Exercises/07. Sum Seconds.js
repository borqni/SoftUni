function sumSeconds([arg1, arg2, arg3]) {
    a = Number(arg1);
    b = Number(arg2);
    c = Number(arg3);
    let sumSec = a + b + c;
    let min = parseInt(sumSec / 60);
    let ostSec = sumSec % 60;
    if (ostSec < 10) {
        console.log(`${min}:0${ostSec}`);
    } else {
        console.log(`${min}:${ostSec}`);
    }
}