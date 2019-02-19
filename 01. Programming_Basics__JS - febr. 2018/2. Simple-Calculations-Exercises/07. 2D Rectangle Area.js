function test([x1, y1, x2, y2]) {
    let baseA = Math.max(x1, x2) - Math.min(x1, x2);
    let baseB = Math.max(y1, y2) - Math.min(y1, y2);
    let area = baseA * baseB;
    let perimeter = 2 * (baseA + baseB);

    console.log('Area = ' + area);
    console.log('Perimeter = ' + perimeter)
}