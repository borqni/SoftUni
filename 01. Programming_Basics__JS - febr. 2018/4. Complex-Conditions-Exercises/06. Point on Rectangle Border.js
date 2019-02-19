function solve([arg1, arg2, arg3, arg4, arg5, arg6]) {
    x1 = Number(arg1);
    y1 = Number(arg2);
    x2 = Number(arg3);
    y2 = Number(arg4);
    x = Number(arg5);
    y = Number(arg6);

    if (((x == x1 || x == x2) && y >= y1 && y <= y2) ||
        ((y1 == y || y == y2) && x >= x1 && x <= x2)) {
        console.log('Border');
    } else {
        console.log('Inside / Outside');
    }
}