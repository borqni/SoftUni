function radToDeg([arg1]) {
    let rad = Number(arg1);
    let deg = Math.round((rad * (180 / Math.PI)));

    console.log(deg);
}