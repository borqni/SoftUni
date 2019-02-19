function pointInRectangle([arg1, arg2, arg3, arg4, arg5, arg6]) {
    x1 = Number(arg1);
    y1 = Number(arg2);
    x2 = Number(arg3);
    y2 = Number(arg4);
    x = Number(arg5);
    y = Number(arg6);

    if (x1 <= x && x <= x2 && y1 <= y && y <= y2) {
        console.log('Inside');
    } else {
        console.log('Outside');
    }
}