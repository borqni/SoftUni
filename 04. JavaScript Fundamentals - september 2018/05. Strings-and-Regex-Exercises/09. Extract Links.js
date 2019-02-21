function solve(arr) {
    let input = arr.join(' ');
    let regex = /www\.[A-Za-z0-9\-]+(\.[a-z]+)+/gm;
    let match = input.match(regex);

    if (match === null) {
        console.log()
    } else {
        console.log(match.join('\n'));
    }
}

solve(['Join WebStars now for free, at www.web-stars.com',
    'You can also support our partners:',
    'Internet - www.internet.com',
    'WebSpiders - www.webspiders101.com',
    'Sentinel - www.sentinel.-ko'
])